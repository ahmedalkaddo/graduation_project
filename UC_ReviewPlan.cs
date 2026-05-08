//using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenAI;
using OpenAI.Chat;
using iTextSharp.text.pdf;
//using iTextSharp.text.pdf.parser;
using iTextSharp.text;
using iTextSharp.text.pdf.parser;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace SmartEduAssistant
{
    public partial class UC_ReviewPlan : UserControl
    {
        string apiKey = "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";

        public UC_ReviewPlan()
        {
            InitializeComponent();
        }

        private async Task<string> GenerateReviewPlan(string input, int days, int hours)
        {
            var client = new OpenAIClient("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");

            var response = await client.GetChatClient("gpt-4.1-mini")
                .CompleteChatAsync($"أنشئ خطة مراجعة لمدة {days} أيام، {hours} ساعات يومياً:\n{input}");

            return response.Value.Content[0].Text;
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

                TxtInput.Text = text.ToString();
            }
        }

        private void BtnDelet_Click(object sender, EventArgs e)
        {
            TxtOutput.Clear();
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
                    TxtOutput.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);

                    MessageBox.Show("تم حفظ الملف بنجاح");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء الحفظ: " + ex.Message);
                }
            }
        }

        private async void BtnReview_Click(object sender, EventArgs e)
        {

            // التأكد من وجود نص
            if (string.IsNullOrWhiteSpace(TxtInput.Text))
            {
                MessageBox.Show("الرجاء إدخال أو رفع محتوى أولاً");
                return;
            }

            string topic = TxtInput.Text.ToString();
            int days = int.Parse(NumDays.Text);
            int hours = int.Parse(NumClock.Text);

            label10.Text = "⏳ جاري تلخيص المحتوى...";

            try
            {
                string content = await GenerateQuestionsFromAPI(topic, days, hours);



                TxtOutput.Text = content;
                label10.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء توليد الأسئلة:\n" + ex.Message);
            }


        }

        private async Task<string> GenerateQuestionsFromAPI(
string topic,
int days,
int hours
)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", apiKey);

                var prompt = $@"
اصنع خطة مراجهة للموضوع التالي:
{topic}
حيث ان ايام المراجعة هي {days} يوم، وساعات المراجعة اليومية هي {hours} ساعة.
بشكل احترافي وواضح.
";

                var requestBody = new
                {
                    model = "gpt-4o-mini",
                    messages = new[]
                    {
                new { role = "system", content = "أنت صانع خطة مراجهة احترافي للمواد الدراسية" },
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

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
