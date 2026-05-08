using System;
using System.Windows.Forms;
namespace SmartEduAssistant
{
    public partial class MainForm : Form
    {
        public MainForm()

        {
            InitializeComponent();
        }
        public void LoadUserControl(UserControl uc)
        {
            pnlMainContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(uc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReviewPlan_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_ReviewPlan());
        }

        private void pnlMainContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnSummarize_Click(object sender, EventArgs e)
        {
            LoadUserControl(new summary_new());
        }

        private void btnQuestions_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_QuestionGenerator());
        }

        private void btnExplain_Click(object sender, EventArgs e)
        {
       LoadUserControl(new explain());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Search());
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {

            LoadUserControl(new UC_QuizInfo());
        }
    }
}
