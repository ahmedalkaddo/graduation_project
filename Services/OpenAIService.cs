using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace SmartEduAssistant.Services
{
    public class OpenAIService
    {
        private readonly HttpClient _http;
        private readonly string _apiKey;

        public OpenAIService(HttpClient http = null)
        {
            _http = http ?? new HttpClient();

            // Try environment variable first
            _apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
            // Fallback: read from a file in the user's AppData folder (do NOT commit this file)
            string fallbackPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SmartEduAssistant", "openai.key");
            try
            {
                if (string.IsNullOrWhiteSpace(_apiKey) && File.Exists(fallbackPath))
                {
                    _apiKey = File.ReadAllText(fallbackPath).Trim();
                }
            }
            catch (Exception ex)
            {
                // ignore read errors here and surface a clearer message below
                Console.WriteLine("Could not read API key file: " + ex.Message);
            }

            if (string.IsNullOrWhiteSpace(_apiKey))
            {
                throw new InvalidOperationException($"OpenAI API key not found. Set the OPENAI_API_KEY environment variable or place your key in: {fallbackPath}");
            }
        }

        public async Task<string> GenerateQuizAsync(int numberOfQuestions, string level, string questionType, string content)
        {
            // Build prompt - instruct model to return JSON only, matching the contract
            string userPrompt = $"You are to generate {numberOfQuestions} {questionType} questions. Return ONLY JSON and nothing else.\n" +
                "If multiple choice, return an object with a single property \"questions\" containing an array of objects.\n" +
                "Each question object should have: \"questionText\" (string), \"options\" (array of 4 strings), and \"correctAnswer\" (string, equal to one option).\n" +
                "If true/false, return questions array where each object has \"questionText\" (string) and \"correctAnswer\" (boolean true or false).\n" +
                $"Make sure there are exactly {numberOfQuestions} items in the questions array. Difficulty: {level}.\n" +
                $"Source text (use this to craft questions):\n{content}\n\nDo not include any explanatory text, markdown, or commentary. Return exactly valid JSON.";

            var requestBody = new
            {
                model = "gpt-3.5-turbo",
                messages = new[]
                {
                    new { role = "system", content = "You are a JSON generator. Return JSON only." },
                    new { role = "user", content = userPrompt }
                },
                max_tokens = 1500,
                temperature = 0.2
            };

            var json = JsonSerializer.Serialize(requestBody);
            using var request = new HttpRequestMessage(HttpMethod.Post, "https://api.openai.com/v1/chat/completions");
            request.Headers.Add("Authorization", $"Bearer {_apiKey}");
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            using var response = await _http.SendAsync(request).ConfigureAwait(false);
            var respStr = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                throw new InvalidOperationException($"OpenAI request failed: {response.StatusCode} - {respStr}");
            }

            // Parse chat completion response to extract the assistant message
            using var doc = JsonDocument.Parse(respStr);
            if (doc.RootElement.TryGetProperty("choices", out var choices) && choices.GetArrayLength() > 0)
            {
                var first = choices[0];
                if (first.TryGetProperty("message", out var message) && message.TryGetProperty("content", out var contentElem))
                {
                    var contentString = contentElem.GetString();
                    if (string.IsNullOrWhiteSpace(contentString))
                        throw new InvalidOperationException("OpenAI returned an empty content.");

                    // The assistant may sometimes wrap JSON in backticks or whitespace; try to extract the first JSON object/array.
                    contentString = ExtractJsonSubstring(contentString);
                    return contentString;
                }
            }

            throw new InvalidOperationException("Unexpected OpenAI response format.");
        }

        private static string ExtractJsonSubstring(string text)
        {
            // Trim and remove code fences if present
            text = text.Trim();
            if (text.StartsWith("```"))
            {
                // remove triple backticks and optional language declaration
                var idx = text.IndexOf('\n');
                if (idx >= 0) text = text.Substring(idx + 1);
                if (text.EndsWith("```")) text = text.Substring(0, text.Length - 3);
                return text.Trim();
            }

            // Try to find start of JSON object
            var start = text.IndexOf('{');
            var end = text.LastIndexOf('}');
            if (start >= 0 && end > start)
                return text.Substring(start, end - start + 1).Trim();

            // fallback
            return text;
        }
    }
}
