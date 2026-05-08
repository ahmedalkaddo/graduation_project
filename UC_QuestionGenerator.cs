using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using  iTextSharp.text;

namespace SmartEduAssistant
{
    public partial class UC_QuestionGenerator : UserControl
    {
        string apiKey = "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";
        public UC_QuestionGenerator()
        {
            InitializeComponent();
        }
        private async Task<string> GenerateQuestionsFromAPI(
string topic,
string questionType,
string level,
int count)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", apiKey);

                var prompt = $@"
أنشئ {count} أسئلة من نوع ({questionType})
بمستوى ({level})
حول الموضوع التالي:
{topic}

اكتب الأسئلة فقط بدون إجابات.
";

                var requestBody = new
                {
                    model = "gpt-4o-mini",
                    messages = new[]
                    {
                new { role = "system", content = "أنت مولد أسئلة تعليمية باللغة العربية" },
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
        private void button2_Click(object sender, EventArgs e)
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

                txtInput.Text = text.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
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
                    rtxtOutput.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);

                    MessageBox.Show("تم حفظ الملف بنجاح");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء الحفظ: " + ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtxtOutput.Text))
            {
                rtxtOutput.SelectAll();
                rtxtOutput.Copy();
                MessageBox.Show("تم نسخ النص بنجاح!", "نسخ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لا يوجد نص لنسخه!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtOutput.Clear();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (combTypeQustion.SelectedIndex == -1 ||
     combTypeQustion.SelectedIndex == -1)
            {
                MessageBox.Show("يرجى اختيار نوع ومستوى الأسئلة");
                return;
            }

            string questionType = combTypeQustion.SelectedItem.ToString();
            string level = combTypeQustion.SelectedItem.ToString();
            int count = (int)numeNumberofQustion.Value;

            string topic = txtInput.Text.ToString();

            rtxtOutput.Text = "⏳ جاري توليد الأسئلة...";

            try
            {
                string questions = await GenerateQuestionsFromAPI(
                    topic, questionType, level, count);


                rtxtOutput.Text = questions;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء توليد الأسئلة:\n" + ex.Message);
            }
        }
    }
}
