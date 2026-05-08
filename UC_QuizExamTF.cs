using OpenAI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartEduAssistant
{
    public partial class UC_QuizExamTF : UserControl
    {
        int numQuestions;
        string level;
        public UC_QuizExamTF(int num, string lvl)
        {
            InitializeComponent();
            numQuestions = num;
            level = lvl;
        }
        private async Task<string> GetQuestionsFromGPT()
        {
            var client = new OpenAIClient("YOUR_API_KEY");

            var chatClient = client.GetChatClient("gpt-4o-mini");

            string prompt = $"أنشئ {numQuestions} أسئلة اختيار من متعدد بمستوى {level}، كل سؤال يحتوي 4 خيارات وحدد الإجابة الصحيحة.";

            var response = await chatClient.CompleteChatAsync(prompt);

            return response.Value.Content[0].Text;
        }
        private async void loadQustions()
        {
            string result = await GetQuestionsFromGPT();

            RichTextBox box = new RichTextBox();
            box.Dock = DockStyle.Fill;
            box.Text = result;

            this.Controls.Add(box);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GrpBoxTF_Enter(object sender, EventArgs e)
        {

        }
    }
}
