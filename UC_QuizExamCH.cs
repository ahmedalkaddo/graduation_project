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
using Org.BouncyCastle.Asn1.Crmf;

namespace SmartEduAssistant
{
    public partial class UC_QuizExamCH : UserControl
    {
        string apiKey = "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";
        int numQuestions;
        string level;
        string contents;
        public UC_QuizExamCH(int num, string lvl, string txtInput)
        {
            InitializeComponent();
            numQuestions = num;
            level = lvl;
            contents = txtInput;

            loadQustions();

        }
        private async Task<string> GetQuestionsFromGPT()
        {
            var client = new OpenAIClient("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");

            var chatClient = client.GetChatClient("gpt-4o-mini");

            string prompt = $"قم بإنشاء {numQuestions} أسئلة اختيار من متعدد بمستوى {level}  مع 4 خيارات وحدد الإجابة الصحيحة. حيث ان المحتوى هو {contents}";

            var response = await chatClient.CompleteChatAsync(prompt);

            return response.Value.Content[0].Text;
        }
        private async void loadQustions()
        {
            string result = await GetQuestionsFromGPT();

            TextBox txt = new TextBox();
            txt.Multiline = true;
            txt.Width = 500;
            txt.Height = 300;
            txt.Text = result;

            this.Controls.Add(txt);
        }

        private void btnNextCH_Click(object sender, EventArgs e)
        {

        }
    }

}

