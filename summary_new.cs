using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Math.Primes;

namespace SmartEduAssistant
{
    public partial class summary_new : UserControl
    {
        string apiKey = "ضع المفتاح الخاص بك هنا";
        public summary_new()
        {
            InitializeComponent();
        }

        private void summary_new_Load(object sender, EventArgs e)
        {
        }

        private void btnUploadPDF_Click(object sender, EventArgs e)
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

                rtxtInput.Text = text.ToString();
            }
        }

        private async void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnSummary_Click(object sender, EventArgs e)
        {


            string topic = rtxtInput.Text.ToString();

            label1.Text = "⏳ جاري تلخيص المحتوى...";

            try
            {
                string content = await GenerateQuestionsFromAPI(topic);


                RtxtOutput.Text = content;
                label1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء توليد الأسئلة:\n" + ex.Message);
            }
        }

        private async Task<string> GenerateQuestionsFromAPI(
string topic
)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", apiKey);

                var prompt = $@"
لخص الموضوع التالي:
{topic}

بشكل موجز وواضح، مع التركيز على النقاط الرئيسية والمعلومات الهامة.
";

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

        private void btnSavePDF_Click(object sender, EventArgs e)
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
                    RtxtOutput.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);

                    MessageBox.Show("تم حفظ الملف بنجاح");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء الحفظ: " + ex.Message);
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            RtxtOutput.Clear();
        }
    }
}
