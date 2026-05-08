namespace SmartEduAssistant
{
    partial class UC_QuizExamTF
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlFooterTF = new Panel();
            BtnReturnTF = new Button();
            lblLogo = new Label();
            lblStatusTF = new Label();
            btnNextTF = new Button();
            pnlHeaderTF = new Panel();
            lblQuestionCounterTF = new Label();
            lblQuizTitleTF = new Label();
            pnlTF = new Panel();
            GrpBoxTF = new GroupBox();
            RadBtnT = new RadioButton();
            RadBtnF = new RadioButton();
            lblQuestionTF = new Label();
            pnlFooterTF.SuspendLayout();
            pnlHeaderTF.SuspendLayout();
            pnlTF.SuspendLayout();
            GrpBoxTF.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFooterTF
            // 
            pnlFooterTF.BackColor = Color.Gainsboro;
            pnlFooterTF.Controls.Add(BtnReturnTF);
            pnlFooterTF.Controls.Add(lblLogo);
            pnlFooterTF.Controls.Add(lblStatusTF);
            pnlFooterTF.Controls.Add(btnNextTF);
            pnlFooterTF.Dock = DockStyle.Bottom;
            pnlFooterTF.Location = new Point(0, 796);
            pnlFooterTF.Name = "pnlFooterTF";
            pnlFooterTF.Size = new Size(1360, 162);
            pnlFooterTF.TabIndex = 0;
            pnlFooterTF.Paint += panel1_Paint;
            // 
            // BtnReturnTF
            // 
            BtnReturnTF.BackColor = Color.Gray;
            BtnReturnTF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnReturnTF.ForeColor = Color.Gainsboro;
            BtnReturnTF.Location = new Point(879, 41);
            BtnReturnTF.Name = "BtnReturnTF";
            BtnReturnTF.Size = new Size(205, 55);
            BtnReturnTF.TabIndex = 3;
            BtnReturnTF.Text = "رجوع";
            BtnReturnTF.UseVisualStyleBackColor = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogo.Location = new Point(3, 119);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(285, 31);
            lblLogo.TabIndex = 2;
            lblLogo.Text = "SmartEduAssistant © 2025";
            // 
            // lblStatusTF
            // 
            lblStatusTF.AutoSize = true;
            lblStatusTF.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusTF.Location = new Point(3, 19);
            lblStatusTF.Name = "lblStatusTF";
            lblStatusTF.RightToLeft = RightToLeft.Yes;
            lblStatusTF.Size = new Size(190, 31);
            lblStatusTF.TabIndex = 1;
            lblStatusTF.Text = "اختر اجابة للمتابعة ";
            lblStatusTF.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNextTF
            // 
            btnNextTF.AutoSize = true;
            btnNextTF.BackColor = Color.DarkSlateGray;
            btnNextTF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextTF.ForeColor = Color.Gainsboro;
            btnNextTF.Location = new Point(1124, 41);
            btnNextTF.Name = "btnNextTF";
            btnNextTF.Size = new Size(205, 55);
            btnNextTF.TabIndex = 0;
            btnNextTF.Text = "التالي";
            btnNextTF.UseVisualStyleBackColor = false;
            // 
            // pnlHeaderTF
            // 
            pnlHeaderTF.BackColor = Color.Gainsboro;
            pnlHeaderTF.Controls.Add(lblQuestionCounterTF);
            pnlHeaderTF.Controls.Add(lblQuizTitleTF);
            pnlHeaderTF.Dock = DockStyle.Top;
            pnlHeaderTF.Location = new Point(0, 0);
            pnlHeaderTF.Name = "pnlHeaderTF";
            pnlHeaderTF.Size = new Size(1360, 97);
            pnlHeaderTF.TabIndex = 1;
            pnlHeaderTF.Paint += pnlHeader_Paint;
            // 
            // lblQuestionCounterTF
            // 
            lblQuestionCounterTF.AutoSize = true;
            lblQuestionCounterTF.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestionCounterTF.ForeColor = Color.Maroon;
            lblQuestionCounterTF.Location = new Point(3, 63);
            lblQuestionCounterTF.Name = "lblQuestionCounterTF";
            lblQuestionCounterTF.RightToLeft = RightToLeft.Yes;
            lblQuestionCounterTF.Size = new Size(144, 31);
            lblQuestionCounterTF.TabIndex = 2;
            lblQuestionCounterTF.Text = "السؤال 1 من 5 ";
            lblQuestionCounterTF.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQuizTitleTF
            // 
            lblQuizTitleTF.AutoSize = true;
            lblQuizTitleTF.FlatStyle = FlatStyle.Flat;
            lblQuizTitleTF.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuizTitleTF.Location = new Point(1155, 0);
            lblQuizTitleTF.Name = "lblQuizTitleTF";
            lblQuizTitleTF.RightToLeft = RightToLeft.No;
            lblQuizTitleTF.Size = new Size(205, 38);
            lblQuizTitleTF.TabIndex = 1;
            lblQuizTitleTF.Text = "اختبار المعلومات";
            // 
            // pnlTF
            // 
            pnlTF.Controls.Add(GrpBoxTF);
            pnlTF.Controls.Add(lblQuestionTF);
            pnlTF.Dock = DockStyle.Fill;
            pnlTF.Location = new Point(0, 97);
            pnlTF.Name = "pnlTF";
            pnlTF.Size = new Size(1360, 699);
            pnlTF.TabIndex = 2;
            // 
            // GrpBoxTF
            // 
            GrpBoxTF.BackColor = Color.LightGray;
            GrpBoxTF.Controls.Add(RadBtnT);
            GrpBoxTF.Controls.Add(RadBtnF);
            GrpBoxTF.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GrpBoxTF.ForeColor = Color.DarkSlateGray;
            GrpBoxTF.Location = new Point(320, 234);
            GrpBoxTF.Name = "GrpBoxTF";
            GrpBoxTF.RightToLeft = RightToLeft.Yes;
            GrpBoxTF.Size = new Size(820, 371);
            GrpBoxTF.TabIndex = 1;
            GrpBoxTF.TabStop = false;
            GrpBoxTF.Text = "اختر الاجابة الصحيحة";
            GrpBoxTF.Enter += GrpBoxTF_Enter;
            // 
            // RadBtnT
            // 
            RadBtnT.AutoSize = true;
            RadBtnT.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RadBtnT.ForeColor = Color.Teal;
            RadBtnT.Location = new Point(640, 140);
            RadBtnT.Name = "RadBtnT";
            RadBtnT.Size = new Size(82, 42);
            RadBtnT.TabIndex = 2;
            RadBtnT.TabStop = true;
            RadBtnT.Text = "صح";
            RadBtnT.UseVisualStyleBackColor = true;
            // 
            // RadBtnF
            // 
            RadBtnF.AutoSize = true;
            RadBtnF.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RadBtnF.ForeColor = Color.Crimson;
            RadBtnF.Location = new Point(638, 233);
            RadBtnF.Name = "RadBtnF";
            RadBtnF.Size = new Size(84, 42);
            RadBtnF.TabIndex = 3;
            RadBtnF.TabStop = true;
            RadBtnF.Text = "خطأ";
            RadBtnF.UseVisualStyleBackColor = true;
            // 
            // lblQuestionTF
            // 
            lblQuestionTF.AutoSize = true;
            lblQuestionTF.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblQuestionTF.Location = new Point(563, 87);
            lblQuestionTF.Name = "lblQuestionTF";
            lblQuestionTF.Size = new Size(286, 38);
            lblQuestionTF.TabIndex = 0;
            lblQuestionTF.Text = "سيظهر نص السؤال هنا ";
            // 
            // UC_QuizExamTF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlTF);
            Controls.Add(pnlHeaderTF);
            Controls.Add(pnlFooterTF);
            Name = "UC_QuizExamTF";
            Size = new Size(1360, 958);
            pnlFooterTF.ResumeLayout(false);
            pnlFooterTF.PerformLayout();
            pnlHeaderTF.ResumeLayout(false);
            pnlHeaderTF.PerformLayout();
            pnlTF.ResumeLayout(false);
            pnlTF.PerformLayout();
            GrpBoxTF.ResumeLayout(false);
            GrpBoxTF.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFooterTF;
        private Panel pnlHeaderTF;
        private Label lblQuizTitleTF;
        private Button btnNextTF;
        private Label lblStatusTF;
        private Label lblQuestionCounterTF;
        private Label lblLogo;
        private Panel pnlTF;
        private GroupBox GrpBoxTF;
        private Label lblQuestionTF;
        private RadioButton RadBtnT;
        private RadioButton RadBtnF;
        private Button BtnReturnTF;
    }
}
