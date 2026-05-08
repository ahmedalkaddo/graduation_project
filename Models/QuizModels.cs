using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmartEduAssistant.Models
{
    public class QuizResponse
    {
        [JsonPropertyName("questions")]
        public List<QuizQuestion> Questions { get; set; } = new();
    }

    public class QuizQuestion
    {
        [JsonPropertyName("questionText")]
        public string QuestionText { get; set; }

        [JsonPropertyName("options")]
        public List<string> Options { get; set; }

        [JsonPropertyName("correctAnswer")]
        public JsonElement CorrectAnswerRaw { get; set; }

        public bool CorrectAnswerIsBoolean => CorrectAnswerRaw.ValueKind == JsonValueKind.True || CorrectAnswerRaw.ValueKind == JsonValueKind.False;

        public bool? CorrectAnswerBool
        {
            get
            {
                if (CorrectAnswerIsBoolean)
                    return CorrectAnswerRaw.GetBoolean();
                return null;
            }
        }

        public string CorrectAnswerString
        {
            get
            {
                if (CorrectAnswerRaw.ValueKind == JsonValueKind.String)
                    return CorrectAnswerRaw.GetString();
                // If boolean, return true/false as string
                if (CorrectAnswerIsBoolean)
                    return CorrectAnswerRaw.GetBoolean() ? "true" : "false";
                return CorrectAnswerRaw.ToString();
            }
        }
    }
}
