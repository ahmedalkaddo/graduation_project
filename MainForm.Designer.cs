namespace SmartEduAssistant
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnlSideMenu = new Panel();
            btnQuiz = new Button();
            btnSearch = new Button();
            btnReviewPlan = new Button();
            btnQuestions = new Button();
            btnSummarize = new Button();
            lbtitelmain = new Label();
            picLogo = new PictureBox();
            pnlMainContent = new Panel();
            lbjob = new Label();
            lbwellcome = new Label();
            pnlSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlMainContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.BackColor = Color.DarkSlateGray;
            pnlSideMenu.Controls.Add(btnQuiz);
            pnlSideMenu.Controls.Add(btnSearch);
            pnlSideMenu.Controls.Add(btnReviewPlan);
            pnlSideMenu.Controls.Add(btnQuestions);
            pnlSideMenu.Controls.Add(btnSummarize);
            pnlSideMenu.Controls.Add(lbtitelmain);
            pnlSideMenu.Controls.Add(picLogo);
            pnlSideMenu.Dock = DockStyle.Left;
            pnlSideMenu.Location = new Point(0, 0);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.Size = new Size(306, 964);
            pnlSideMenu.TabIndex = 0;
            // 
            // btnQuiz
            // 
            btnQuiz.Dock = DockStyle.Top;
            btnQuiz.FlatStyle = FlatStyle.Flat;
            btnQuiz.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuiz.ForeColor = Color.White;
            btnQuiz.Location = new Point(0, 675);
            btnQuiz.Name = "btnQuiz";
            btnQuiz.Size = new Size(306, 85);
            btnQuiz.TabIndex = 8;
            btnQuiz.Text = "📚 اختبار المعلومات";
            btnQuiz.UseVisualStyleBackColor = true;
            btnQuiz.Click += btnQuiz_Click;
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Top;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(0, 590);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(306, 85);
            btnSearch.TabIndex = 7;
            btnSearch.Text = " 🔍  البحث عن المعلومات";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReviewPlan
            // 
            btnReviewPlan.Dock = DockStyle.Top;
            btnReviewPlan.FlatStyle = FlatStyle.Flat;
            btnReviewPlan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReviewPlan.ForeColor = Color.White;
            btnReviewPlan.Location = new Point(0, 505);
            btnReviewPlan.Name = "btnReviewPlan";
            btnReviewPlan.Padding = new Padding(15, 0, 0, 0);
            btnReviewPlan.Size = new Size(306, 85);
            btnReviewPlan.TabIndex = 3;
            btnReviewPlan.Text = "📅  خطة مراجعة";
            btnReviewPlan.UseVisualStyleBackColor = true;
            btnReviewPlan.Click += btnReviewPlan_Click;
            // 
            // btnQuestions
            // 
            btnQuestions.Dock = DockStyle.Top;
            btnQuestions.FlatStyle = FlatStyle.Flat;
            btnQuestions.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuestions.ForeColor = Color.White;
            btnQuestions.Location = new Point(0, 420);
            btnQuestions.Name = "btnQuestions";
            btnQuestions.Padding = new Padding(15, 0, 0, 0);
            btnQuestions.Size = new Size(306, 85);
            btnQuestions.TabIndex = 1;
            btnQuestions.Text = "❔ توليد الاسئلة  ";
            btnQuestions.UseVisualStyleBackColor = true;
            btnQuestions.Click += btnQuestions_Click;
            // 
            // btnSummarize
            // 
            btnSummarize.Dock = DockStyle.Top;
            btnSummarize.FlatStyle = FlatStyle.Flat;
            btnSummarize.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSummarize.ForeColor = Color.White;
            btnSummarize.Location = new Point(0, 335);
            btnSummarize.Name = "btnSummarize";
            btnSummarize.Padding = new Padding(15, 0, 0, 0);
            btnSummarize.Size = new Size(306, 85);
            btnSummarize.TabIndex = 0;
            btnSummarize.Text = "📝  تلخيص الدروس   ";
            btnSummarize.UseVisualStyleBackColor = true;
            btnSummarize.Click += btnSummarize_Click;
            // 
            // lbtitelmain
            // 
            lbtitelmain.Dock = DockStyle.Top;
            lbtitelmain.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbtitelmain.ForeColor = Color.White;
            lbtitelmain.Location = new Point(0, 185);
            lbtitelmain.Margin = new Padding(0);
            lbtitelmain.Name = "lbtitelmain";
            lbtitelmain.Size = new Size(306, 150);
            lbtitelmain.TabIndex = 4;
            lbtitelmain.Text = "SmartEduAssistant";
            lbtitelmain.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Top;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(0, 0);
            picLogo.Margin = new Padding(10);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(306, 185);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 5;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // pnlMainContent
            // 
            pnlMainContent.BackColor = Color.Gainsboro;
            pnlMainContent.Controls.Add(lbjob);
            pnlMainContent.Controls.Add(lbwellcome);
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Location = new Point(306, 0);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(1128, 964);
            pnlMainContent.TabIndex = 1;
            pnlMainContent.Paint += pnlMainContent_Paint;
            // 
            // lbjob
            // 
            lbjob.AutoSize = true;
            lbjob.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbjob.ForeColor = SystemColors.GrayText;
            lbjob.Location = new Point(635, 606);
            lbjob.Name = "lbjob";
            lbjob.Size = new Size(419, 38);
            lbjob.TabIndex = 1;
            lbjob.Text = "اختر وظيفة من القائمة الجانبية للبدء";
            lbjob.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbwellcome
            // 
            lbwellcome.AutoSize = true;
            lbwellcome.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbwellcome.ForeColor = SystemColors.GrayText;
            lbwellcome.Location = new Point(569, 419);
            lbwellcome.Name = "lbwellcome";
            lbwellcome.Size = new Size(559, 46);
            lbwellcome.TabIndex = 0;
            lbwellcome.Text = " SmartEduAssistant   مرحباً بك في   ";
            lbwellcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1434, 964);
            Controls.Add(pnlMainContent);
            Controls.Add(pnlSideMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SmartEduAssistant";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            pnlSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlMainContent.ResumeLayout(false);
            pnlMainContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideMenu;
        private Panel pnlMainContent;
        private Button btnReviewPlan;
        private Button btnExplain;
        private Button btnQuestions;
        private Button btnSummarize;
        private Label lbtitelmain;
        private PictureBox picLogo;
        private Label lbjob;
        private Label lbwellcome;
        private Button btnSearch;
        private Button btnQuiz;
    }
}
