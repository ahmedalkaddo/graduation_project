using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Org.BouncyCastle.Asn1.Cmp;
using SmartEduAssistant.Models;
using SmartEduAssistant.Services;
using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SmartEduAssistant
{
    public partial class UC_QuizInfo : UserControl
    {
        private readonly FileReaderService _fileReader;
        private readonly OpenAIService _openAi;

        public UC_QuizInfo()
        {
            InitializeComponent();
            _fileReader = new FileReaderService();
            try
            {
                _openAi = new OpenAIService();
            }
            catch (Exception ex)
            {
                // Delay throwing; only show message in UI when needed
                _openAi = null;
                Console.WriteLine("OpenAIService init error: " + ex.Message);
            }
        }

        private void OpenUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private async void btnUpload_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pnlSettings_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_QuizInfo_Load(object sender, EventArgs e)
        {

        }

        private void pnlBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void ButStartExam_Click(object sender, EventArgs e)
        {
            // Pseudocode / plan (detailed):
            // 1. Read number of questions and validate required list selections.
            // 2. Ensure OpenAI service is available and question type is selected.
            // 3. Read the text input content from TxtInput.
            // 4. Determine whether the "input mode" radio button (named "R1Input") is selected.
            //    - The project may not have a field named R1Input (designer omitted it). To avoid CS0103
            //      we detect the field at runtime via reflection. If present, use its Checked value.
            //    - If not present, fall back to a conservative behavior (do not require input unless you
            //      explicitly want that behavior). Here we treat missing control as "not input mode"
            //      to avoid blocking the flow; adjust as needed.
            // 5. If input mode is selected and content is empty, show message and abort.
            // 6. Set UI loading state, call OpenAI generation, parse JSON, show QuizForm on UI thread.
            // 7. Restore UI state in finally block.

            int num = (int)NumNofQustion.Value;

            if (LstLevelQust.SelectedItem == null)
            {
                MessageBox.Show("اختر مستوى الأسئلة");
                return;
            }

            string level = LstLevelQust.SelectedItem.ToString();

            if (!_openAiIsAvailable())
            {
                MessageBox.Show("خدمة OpenAI غير متاحة. تأكد من تعيين متغير البيئة OPENAI_API_KEY.");
                return;
            }

            bool isMC = R3MultiChoise.Checked;
            bool isTF = R4ToF.Checked;
            if (!isMC && !isTF)
            {
                MessageBox.Show("اختر نوع الأسئلة");
                return;
            }

            string content = TxtInput.Text?.Trim();
            if (string.IsNullOrWhiteSpace(content))
            {
                MessageBox.Show("يرجى إدخال النص قبل بدء الاختبار");
                return;
            }

            // Show loading state
            ButStartExam.Enabled = false;
            label22.Text = "جاري توليد الأسئلة... الرجاء الانتظار";

            try
            {
                string type = isMC ? "Multiple Choice" : "True/False";
                var json = await _openAi.GenerateQuizAsync(num, level, type, content).ConfigureAwait(false);

                // parse JSON
                var opts = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var quiz = JsonSerializer.Deserialize<QuizResponse>(json, opts);
                if (quiz == null || quiz.Questions == null || quiz.Questions.Count == 0)
                {
                    MessageBox.Show("لم يتم استلام أسئلة من الخدمة.");
                    return;
                }

                // Show the quiz in a dialog that allows answering
                // switch to UI thread
                this.Invoke((Action)(() =>
                {
                    var qf = new QuizForm(quiz, isMC);
                    qf.ShowDialog();
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء توليد الأسئلة: " + ex.Message);
            }
            finally
            {
                // restore state on UI thread
                this.Invoke((Action)(() =>
                {
                    ButStartExam.Enabled = true;
                    label22.Text = "تم الانتهاء";
                }));
            }
        }

        private bool _openAiIsAvailable()
        {
            return _openAi != null;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TxtInput.Clear();
        }
    }
}
