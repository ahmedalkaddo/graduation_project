namespace SmartEduAssistant
{
    partial class UC_Search
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
            panel1 = new Panel();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            SeachResult = new RichTextBox();
            label5 = new Label();
            BtnSave = new Button();
            label4 = new Label();
            BtnDelet = new Button();
            RichTxtPdf = new RichTextBox();
            BtnUpload = new Button();
            BtnSearch = new Button();
            TxtInput = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 1020);
            panel1.Name = "panel1";
            panel1.Size = new Size(1516, 71);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(246, 28);
            label2.TabIndex = 0;
            label2.Text = "SmartEduAssistant © 2025";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1516, 93);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1261, 0);
            label1.Name = "label1";
            label1.Size = new Size(255, 38);
            label1.TabIndex = 0;
            label1.Text = "البحث عن المعلومات";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(SeachResult);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(BtnSave);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(BtnDelet);
            panel3.Controls.Add(RichTxtPdf);
            panel3.Controls.Add(BtnUpload);
            panel3.Controls.Add(BtnSearch);
            panel3.Controls.Add(TxtInput);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(1516, 927);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(1217, 599);
            label6.Name = "label6";
            label6.Size = new Size(277, 28);
            label6.TabIndex = 12;
            label6.Text = ": ادخل المحتوى المراد البحث عنه ";
            label6.Click += label6_Click;
            // 
            // SeachResult
            // 
            SeachResult.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SeachResult.Location = new Point(105, 85);
            SeachResult.Name = "SeachResult";
            SeachResult.ReadOnly = true;
            SeachResult.ScrollBars = RichTextBoxScrollBars.Vertical;
            SeachResult.Size = new Size(649, 702);
            SeachResult.TabIndex = 11;
            SeachResult.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(770, 320);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 10;
            // 
            // BtnSave
            // 
            BtnSave.AutoSize = true;
            BtnSave.BackColor = Color.CadetBlue;
            BtnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSave.Location = new Point(142, 831);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(302, 55);
            BtnSave.TabIndex = 9;
            BtnSave.Text = " 💾 حفظ ملف ";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(586, 33);
            label4.Name = "label4";
            label4.Size = new Size(118, 28);
            label4.TabIndex = 8;
            label4.Text = ": نتائج البحث ";
            label4.Click += label4_Click;
            // 
            // BtnDelet
            // 
            BtnDelet.AutoSize = true;
            BtnDelet.BackColor = Color.Gainsboro;
            BtnDelet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDelet.Location = new Point(511, 831);
            BtnDelet.Name = "BtnDelet";
            BtnDelet.Size = new Size(155, 55);
            BtnDelet.TabIndex = 6;
            BtnDelet.Text = "مسح ";
            BtnDelet.UseVisualStyleBackColor = false;
            BtnDelet.Click += BtnDelet_Click;
            // 
            // RichTxtPdf
            // 
            RichTxtPdf.BackColor = Color.WhiteSmoke;
            RichTxtPdf.Location = new Point(823, 85);
            RichTxtPdf.Name = "RichTxtPdf";
            RichTxtPdf.Size = new Size(654, 413);
            RichTxtPdf.TabIndex = 4;
            RichTxtPdf.Text = "";
            // 
            // BtnUpload
            // 
            BtnUpload.AutoSize = true;
            BtnUpload.BackColor = Color.Gainsboro;
            BtnUpload.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnUpload.Location = new Point(953, 520);
            BtnUpload.Name = "BtnUpload";
            BtnUpload.Size = new Size(404, 48);
            BtnUpload.TabIndex = 3;
            BtnUpload.Text = "💾  رفع ملف  ";
            BtnUpload.UseVisualStyleBackColor = false;
            BtnUpload.Click += BtnUpload_Click;
            // 
            // BtnSearch
            // 
            BtnSearch.AutoSize = true;
            BtnSearch.BackColor = Color.Gainsboro;
            BtnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSearch.Location = new Point(994, 838);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(416, 48);
            BtnSearch.TabIndex = 2;
            BtnSearch.Text = "🔍 بحث";
            BtnSearch.UseVisualStyleBackColor = false;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // TxtInput
            // 
            TxtInput.BackColor = Color.WhiteSmoke;
            TxtInput.Location = new Point(845, 653);
            TxtInput.Multiline = true;
            TxtInput.Name = "TxtInput";
            TxtInput.Size = new Size(649, 134);
            TxtInput.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1182, 33);
            label3.Name = "label3";
            label3.Size = new Size(268, 28);
            label3.TabIndex = 0;
            label3.Text = ":  ادخل النص او قم برفع ملف    \r\n";
            // 
            // UC_Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_Search";
            Size = new Size(1516, 1091);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private OpenFileDialog openFileDialog1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private Button BtnUpload;
        private Button BtnSearch;
        private TextBox TxtInput;
        private Label label3;
        private Label label4;
        private Button BtnDelet;
        private Button BtnSave;
        private RichTextBox RichTxtPdf;
        private Label label5;
        private RichTextBox SeachResult;
        private Label label6;
    }
}
