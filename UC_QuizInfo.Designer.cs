namespace SmartEduAssistant
{
    partial class UC_QuizInfo
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
            pnlTitle = new Panel();
            lblTitle = new Label();
            groupBox1 = new GroupBox();
            label22 = new Label();
            ButStartExam = new Button();
            groupBox3 = new GroupBox();
            R3MultiChoise = new RadioButton();
            R4ToF = new RadioButton();
            LstLevelQust = new ComboBox();
            label4 = new Label();
            NumNofQustion = new NumericUpDown();
            label1 = new Label();
            label3 = new Label();
            pnlBottom = new Panel();
            lblLogo = new Label();
            btnUpload = new Button();
            pnlInput = new Panel();
            groupBox2 = new GroupBox();
            btnClear = new Button();
            TxtInput = new TextBox();
            label5 = new Label();
            pnlTitle.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumNofQustion).BeginInit();
            pnlBottom.SuspendLayout();
            pnlInput.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.Gainsboro;
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1524, 93);
            pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Right;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(1319, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(205, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "اختبار المعلومات";
            lblTitle.Click += lblTitle_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(ButStartExam);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(LstLevelQust);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(NumNofQustion);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(588, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(915, 863);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(208, 484);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.Name = "label22";
            label22.Size = new Size(0, 28);
            label22.TabIndex = 21;
            // 
            // ButStartExam
            // 
            ButStartExam.BackColor = Color.CadetBlue;
            ButStartExam.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButStartExam.Location = new Point(322, 717);
            ButStartExam.Name = "ButStartExam";
            ButStartExam.Size = new Size(394, 58);
            ButStartExam.TabIndex = 19;
            ButStartExam.Text = "بدء الاختبار";
            ButStartExam.UseVisualStyleBackColor = false;
            ButStartExam.Click += ButStartExam_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(R3MultiChoise);
            groupBox3.Controls.Add(R4ToF);
            groupBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(426, 123);
            groupBox3.Name = "groupBox3";
            groupBox3.RightToLeft = RightToLeft.Yes;
            groupBox3.Size = new Size(400, 169);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "نوع الاسئلة";
            // 
            // R3MultiChoise
            // 
            R3MultiChoise.AutoSize = true;
            R3MultiChoise.CheckAlign = ContentAlignment.MiddleRight;
            R3MultiChoise.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            R3MultiChoise.Location = new Point(210, 62);
            R3MultiChoise.Name = "R3MultiChoise";
            R3MultiChoise.RightToLeft = RightToLeft.No;
            R3MultiChoise.Size = new Size(163, 32);
            R3MultiChoise.TabIndex = 13;
            R3MultiChoise.TabStop = true;
            R3MultiChoise.Text = "اختيار من متعدد";
            R3MultiChoise.UseVisualStyleBackColor = true;
            // 
            // R4ToF
            // 
            R4ToF.AutoSize = true;
            R4ToF.CheckAlign = ContentAlignment.MiddleRight;
            R4ToF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            R4ToF.Location = new Point(246, 112);
            R4ToF.Name = "R4ToF";
            R4ToF.RightToLeft = RightToLeft.No;
            R4ToF.Size = new Size(124, 32);
            R4ToF.TabIndex = 12;
            R4ToF.TabStop = true;
            R4ToF.Text = "صح او خطأ";
            R4ToF.UseVisualStyleBackColor = true;
            // 
            // LstLevelQust
            // 
            LstLevelQust.FormattingEnabled = true;
            LstLevelQust.Items.AddRange(new object[] { "سهل", "متوسط", "صعب" });
            LstLevelQust.Location = new Point(586, 612);
            LstLevelQust.Name = "LstLevelQust";
            LstLevelQust.Size = new Size(254, 36);
            LstLevelQust.TabIndex = 18;
            // 
            // label4
            // 
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(711, 531);
            label4.Name = "label4";
            label4.Size = new Size(185, 35);
            label4.TabIndex = 17;
            label4.Text = " :  مستوى الاسئلة";
            // 
            // NumNofQustion
            // 
            NumNofQustion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NumNofQustion.Location = new Point(586, 425);
            NumNofQustion.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            NumNofQustion.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            NumNofQustion.Name = "NumNofQustion";
            NumNofQustion.Size = new Size(255, 34);
            NumNofQustion.TabIndex = 16;
            NumNofQustion.Value = new decimal(new int[] { 5, 0, 0, 0 });
            NumNofQustion.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(725, 334);
            label1.Name = "label1";
            label1.Size = new Size(171, 35);
            label1.TabIndex = 15;
            label1.Text = "  :  عدد الاسئلة";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(358, 40);
            label3.Name = "label3";
            label3.Size = new Size(161, 31);
            label3.TabIndex = 10;
            label3.Text = "إعدادات الاختبار";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.Gainsboro;
            pnlBottom.Controls.Add(lblLogo);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 968);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(1524, 69);
            pnlBottom.TabIndex = 1;
            pnlBottom.Paint += pnlBottom_Paint;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Dock = DockStyle.Left;
            lblLogo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(246, 28);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "SmartEduAssistant © 2025";
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.CadetBlue;
            btnUpload.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpload.Location = new Point(31, 717);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(314, 58);
            btnUpload.TabIndex = 5;
            btnUpload.Text = "رفع ملف";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // pnlInput
            // 
            pnlInput.BackColor = Color.White;
            pnlInput.Controls.Add(groupBox1);
            pnlInput.Controls.Add(groupBox2);
            pnlInput.Dock = DockStyle.Fill;
            pnlInput.Location = new Point(0, 93);
            pnlInput.Name = "pnlInput";
            pnlInput.Size = new Size(1524, 875);
            pnlInput.TabIndex = 2;
            pnlInput.Paint += panel1_Paint;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnUpload);
            groupBox2.Controls.Add(TxtInput);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(13, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(569, 863);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gainsboro;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(367, 723);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(162, 48);
            btnClear.TabIndex = 7;
            btnClear.Text = "\U0001f9f9 مسح";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // TxtInput
            // 
            TxtInput.Location = new Point(31, 95);
            TxtInput.Multiline = true;
            TxtInput.Name = "TxtInput";
            TxtInput.ScrollBars = ScrollBars.Vertical;
            TxtInput.Size = new Size(487, 584);
            TxtInput.TabIndex = 4;
            // 
            // label5
            // 
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(120, 7);
            label5.Name = "label5";
            label5.Size = new Size(280, 64);
            label5.TabIndex = 0;
            label5.Text = "مصادر محتوى الاختبار";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_QuizInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlInput);
            Controls.Add(pnlBottom);
            Controls.Add(pnlTitle);
            Name = "UC_QuizInfo";
            Size = new Size(1524, 1037);
            Load += UC_QuizInfo_Load;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumNofQustion).EndInit();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            pnlInput.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Label lblTitle;
        private Panel pnlBottom;
        private Label lblLogo;
        private Panel pnlInput;
        private GroupBox groupBox1;
        private RadioButton R3MultiChoise;
        private RadioButton R4ToF;
        private Label label3;
        private Label label1;
        private Label label4;
        private NumericUpDown NumNofQustion;
        private ComboBox LstLevelQust;
        private Button ButStartExam;
        private GroupBox groupBox2;
        private Label label5;
        private Button btnUpload;
        private TextBox TxtInput;
        private GroupBox groupBox3;
        private Label label22;
        private Button btnClear;
    }
}
