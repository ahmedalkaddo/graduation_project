namespace SmartEduAssistant
{
    partial class UC_Result
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
            pnlFooterR = new Panel();
            BtnReturnR = new Button();
            lblLogo = new Label();
            pnlHeaderR = new Panel();
            lblQuizTitleR = new Label();
            pnlTF = new Panel();
            GrpBoxR = new GroupBox();
            lblGrade = new Label();
            lblRatio = new Label();
            lblStatus = new Label();
            lblNumG = new Label();
            lblNumR = new Label();
            lblTxtStatus = new Label();
            pnlFooterR.SuspendLayout();
            pnlHeaderR.SuspendLayout();
            pnlTF.SuspendLayout();
            GrpBoxR.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFooterR
            // 
            pnlFooterR.BackColor = Color.Gainsboro;
            pnlFooterR.Controls.Add(BtnReturnR);
            pnlFooterR.Controls.Add(lblLogo);
            pnlFooterR.Dock = DockStyle.Bottom;
            pnlFooterR.Location = new Point(0, 706);
            pnlFooterR.Name = "pnlFooterR";
            pnlFooterR.Size = new Size(1506, 147);
            pnlFooterR.TabIndex = 3;
            // 
            // BtnReturnR
            // 
            BtnReturnR.BackColor = Color.Gray;
            BtnReturnR.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnReturnR.ForeColor = Color.Gainsboro;
            BtnReturnR.Location = new Point(1114, 44);
            BtnReturnR.Name = "BtnReturnR";
            BtnReturnR.Size = new Size(205, 55);
            BtnReturnR.TabIndex = 3;
            BtnReturnR.Text = "رجوع";
            BtnReturnR.UseVisualStyleBackColor = false;
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
            // pnlHeaderR
            // 
            pnlHeaderR.BackColor = Color.Gainsboro;
            pnlHeaderR.Controls.Add(lblQuizTitleR);
            pnlHeaderR.Dock = DockStyle.Top;
            pnlHeaderR.Location = new Point(0, 0);
            pnlHeaderR.Name = "pnlHeaderR";
            pnlHeaderR.Size = new Size(1506, 97);
            pnlHeaderR.TabIndex = 4;
            // 
            // lblQuizTitleR
            // 
            lblQuizTitleR.AutoSize = true;
            lblQuizTitleR.FlatStyle = FlatStyle.Flat;
            lblQuizTitleR.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuizTitleR.Location = new Point(1155, 0);
            lblQuizTitleR.Name = "lblQuizTitleR";
            lblQuizTitleR.RightToLeft = RightToLeft.No;
            lblQuizTitleR.Size = new Size(205, 38);
            lblQuizTitleR.TabIndex = 1;
            lblQuizTitleR.Text = "اختبار المعلومات";
            lblQuizTitleR.Click += lblQuizTitleR_Click;
            // 
            // pnlTF
            // 
            pnlTF.Controls.Add(GrpBoxR);
            pnlTF.Dock = DockStyle.Fill;
            pnlTF.Location = new Point(0, 0);
            pnlTF.Name = "pnlTF";
            pnlTF.Size = new Size(1506, 853);
            pnlTF.TabIndex = 5;
            // 
            // GrpBoxR
            // 
            GrpBoxR.BackColor = Color.DarkCyan;
            GrpBoxR.Controls.Add(lblTxtStatus);
            GrpBoxR.Controls.Add(lblNumR);
            GrpBoxR.Controls.Add(lblNumG);
            GrpBoxR.Controls.Add(lblStatus);
            GrpBoxR.Controls.Add(lblRatio);
            GrpBoxR.Controls.Add(lblGrade);
            GrpBoxR.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GrpBoxR.ForeColor = Color.Gainsboro;
            GrpBoxR.Location = new Point(312, 202);
            GrpBoxR.Name = "GrpBoxR";
            GrpBoxR.RightToLeft = RightToLeft.Yes;
            GrpBoxR.Size = new Size(919, 437);
            GrpBoxR.TabIndex = 1;
            GrpBoxR.TabStop = false;
            GrpBoxR.Text = "نتيجة الاختبار";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(671, 102);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(183, 38);
            lblGrade.TabIndex = 0;
            lblGrade.Text = "الدرجة النهائية:";
            // 
            // lblRatio
            // 
            lblRatio.AutoSize = true;
            lblRatio.Location = new Point(702, 207);
            lblRatio.Name = "lblRatio";
            lblRatio.Size = new Size(152, 38);
            lblRatio.TabIndex = 1;
            lblRatio.Text = "نسبة النجاح:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(662, 307);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(192, 38);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "  حالة النتيجة:   ";
            // 
            // lblNumG
            // 
            lblNumG.AutoSize = true;
            lblNumG.Location = new Point(464, 102);
            lblNumG.Name = "lblNumG";
            lblNumG.Size = new Size(93, 38);
            lblNumG.TabIndex = 3;
            lblNumG.Text = "10 / 7";
            // 
            // lblNumR
            // 
            lblNumR.AutoSize = true;
            lblNumR.Location = new Point(484, 207);
            lblNumR.Name = "lblNumR";
            lblNumR.Size = new Size(73, 38);
            lblNumR.TabIndex = 4;
            lblNumR.Text = "70%";
            // 
            // lblTxtStatus
            // 
            lblTxtStatus.AutoSize = true;
            lblTxtStatus.Location = new Point(484, 307);
            lblTxtStatus.Name = "lblTxtStatus";
            lblTxtStatus.Size = new Size(65, 38);
            lblTxtStatus.TabIndex = 5;
            lblTxtStatus.Text = "ناجح";
            // 
            // UC_Result
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlFooterR);
            Controls.Add(pnlHeaderR);
            Controls.Add(pnlTF);
            Name = "UC_Result";
            Size = new Size(1506, 853);
            pnlFooterR.ResumeLayout(false);
            pnlFooterR.PerformLayout();
            pnlHeaderR.ResumeLayout(false);
            pnlHeaderR.PerformLayout();
            pnlTF.ResumeLayout(false);
            GrpBoxR.ResumeLayout(false);
            GrpBoxR.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFooterR;
        private Button BtnReturnR;
        private Label lblLogo;
        private Panel pnlHeaderR;
        private Label lblQuizTitleR;
        private Panel pnlTF;
        private GroupBox GrpBoxR;
        private Label lblStatus;
        private Label lblRatio;
        private Label lblGrade;
        private Label lblTxtStatus;
        private Label lblNumR;
        private Label lblNumG;
    }
}
