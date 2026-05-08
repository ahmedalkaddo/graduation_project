using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using Xceed.Words.NET;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using System.DirectoryServices;
using System.Net.Http.Headers;
using static Org.BouncyCastle.Math.Primes;

namespace SmartEduAssistant
{
    public partial class UC_Search : UserControl
    {
        string apiKey = "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";

        public UC_Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF Files (*.pdf)|*.pdf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                StringBuilder text = new StringBuilder();

                using (PdfReader reader = new PdfReader(filePath))
                {
                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                    }
                }

                RichTxtPdf.Text = text.ToString();
            }
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {

            // التأكد من وجود نص
            if (string.IsNullOrWhiteSpace(TxtInput.Text))
            {
                MessageBox.Show("الرجاء إدخال أو رفع محتوى أولاً");
                return;
            }

            string topic = RichTxtPdf.Text;
            string question = TxtInput.Text;

            if (string.IsNullOrWhiteSpace(topic) || string.IsNullOrWhiteSpace(question))
            {
                MessageBox.Show("يرجى إدخال النص والسؤال");
                return;
            }

            label5.Text = "⏳ جاري تلخيص المحتوى...";

            try
            {
                string content = await GenerateQuestionsFromAPI(topic, question);



                SeachResult.Text = content;
                label5.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء توليد الأسئلة:\n" + ex.Message);
            }



            //string fileContent = RichTxtPdf.Text;
            //string question = TxtInput.Text;

            if (string.IsNullOrWhiteSpace(topic) || string.IsNullOrWhiteSpace(question))
            {
                MessageBox.Show("يرجى إدخال النص والسؤال");
                return;
            }

            //string apiKey = "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";

            //using (HttpClient client = new HttpClient())
            //{
            //    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

            //    var requestBody = new
            //    {
            //        model = "gpt-4.1-mini",
            //        input = $"اعتمد فقط على النص التالي:\n{fileContent}\n\nالسؤال: {question}"
            //    };

            //    string json = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);

            //    var content = new StringContent(json, Encoding.UTF8, "application/json");

            //    try
            //    {
            //        var response = await client.PostAsync("https://api.openai.com/v1/responses", content);

            //        var responseString = await response.Content.ReadAsStringAsync();

            //        dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(responseString);

            //        string answer = result.output[0].content[0].text;

            //        SeachResult.Text = answer;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("خطأ: " + ex.Message);
            //    }
            //}
        }

        private void BtnOpenResultLocation_Click(object sender, EventArgs e)
        {
            string resultText = SeachResult.Text;

            if (string.IsNullOrWhiteSpace(resultText))
            {
                MessageBox.Show("لا توجد نتيجة لفتحها");
                return;
            }

            // 🔍 البحث عن رابط داخل النص
            var match = System.Text.RegularExpressions.Regex.Match(resultText, @"https?://\S+");

            if (match.Success)
            {
                // 🌐 فتح الرابط في المتصفح
                string url = match.Value;

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            else
            {
                // 🔎 البحث داخل RichTextBox
                string content = RichTxtPdf.Text;

                int index = content.IndexOf(resultText, StringComparison.OrdinalIgnoreCase);

                if (index >= 0)
                {
                    RichTxtPdf.SelectionStart = index;
                    RichTxtPdf.SelectionLength = resultText.Length;
                    RichTxtPdf.Focus();
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على النص داخل الملف ولا يوجد رابط");
                }
            }
        }

        private void BtnDelet_Click(object sender, EventArgs e)
        {
            SeachResult.Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // أنواع الملفات
            saveFileDialog.Filter = "Word Document (*.doc)|*.doc|All Files (*.*)|*.*";
            saveFileDialog.Title = "حفظ الملف";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // حفظ محتوى richTextBox2 كملف RTF (متوافق مع Word)
                    SeachResult.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);

                    MessageBox.Show("تم حفظ الملف بنجاح");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء الحفظ: " + ex.Message);
                }
            }
        }


        private async Task<string> GenerateQuestionsFromAPI(
string topic, string question
)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", apiKey);

                //        input = $"اعتمد فقط على النص التالي:\n{fileContent}\n\nالسؤال: {question}"

                var prompt = $@"اعتمد فقط على النص التالي:{topic} السؤال: {question}";

                var requestBody = new
                {
                    model = "gpt-4o-mini",
                    messages = new[]
                    {
                new { role = "system", content = "أنت ملخص احترافي للمواد الدراسية" },
                new { role = "user", content = prompt }
            }
                };

                var json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(
                    "https://api.openai.com/v1/chat/completions", content);

                var result = await response.Content.ReadAsStringAsync();
                dynamic data = JsonConvert.DeserializeObject(result);

                return data.choices[0].message.content.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
