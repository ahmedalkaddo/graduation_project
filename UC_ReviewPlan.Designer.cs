namespace SmartEduAssistant
{
    partial class UC_ReviewPlan
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
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            TxtOutput = new RichTextBox();
            label9 = new Label();
            label8 = new Label();
            NumDays = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            BtnSave = new Button();
            BtnReview = new Button();
            NumClock = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            BtnDelet = new Button();
            BtnUpload = new Button();
            TxtInput = new TextBox();
            label3 = new Label();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumDays).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumClock).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1509, 97);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1336, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 38);
            label1.TabIndex = 0;
            label1.Text = "خطة المراجعة";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1132);
            panel2.Name = "panel2";
            panel2.Size = new Size(1509, 60);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(246, 28);
            label2.TabIndex = 0;
            label2.Text = "SmartEduAssistant © 2025";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(TxtOutput);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(NumDays);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(BtnSave);
            panel3.Controls.Add(BtnReview);
            panel3.Controls.Add(NumClock);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(BtnDelet);
            panel3.Controls.Add(BtnUpload);
            panel3.Controls.Add(TxtInput);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 97);
            panel3.Name = "panel3";
            panel3.Size = new Size(1509, 1035);
            panel3.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(471, 536);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 17;
            // 
            // TxtOutput
            // 
            TxtOutput.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtOutput.Location = new Point(20, 124);
            TxtOutput.Name = "TxtOutput";
            TxtOutput.ReadOnly = true;
            TxtOutput.ScrollBars = RichTextBoxScrollBars.Vertical;
            TxtOutput.Size = new Size(715, 734);
            TxtOutput.TabIndex = 16;
            TxtOutput.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(922, 780);
            label9.Name = "label9";
            label9.Size = new Size(56, 28);
            label9.TabIndex = 15;
            label9.Text = "ساعة";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(922, 680);
            label8.Name = "label8";
            label8.Size = new Size(41, 28);
            label8.TabIndex = 14;
            label8.Text = "يوم";
            // 
            // NumDays
            // 
            NumDays.Location = new Point(1038, 681);
            NumDays.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            NumDays.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumDays.Name = "NumDays";
            NumDays.Size = new Size(194, 27);
            NumDays.TabIndex = 13;
            NumDays.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(348, 550);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(582, 42);
            label6.Name = "label6";
            label6.Size = new Size(139, 28);
            label6.TabIndex = 11;
            label6.Text = ":  خطة المراجعة";
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.CadetBlue;
            BtnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSave.Location = new Point(78, 891);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(406, 47);
            BtnSave.TabIndex = 9;
            BtnSave.Text = "💾   حفظ ملف";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnReview
            // 
            BtnReview.BackColor = Color.Gainsboro;
            BtnReview.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnReview.Location = new Point(888, 893);
            BtnReview.Name = "BtnReview";
            BtnReview.Size = new Size(554, 43);
            BtnReview.TabIndex = 8;
            BtnReview.Text = "انشاء خطة المراجعة";
            BtnReview.UseVisualStyleBackColor = false;
            BtnReview.Click += BtnReview_Click;
            // 
            // NumClock
            // 
            NumClock.Location = new Point(1038, 781);
            NumClock.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            NumClock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumClock.Name = "NumClock";
            NumClock.Size = new Size(194, 27);
            NumClock.TabIndex = 7;
            NumClock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(1264, 780);
            label5.Name = "label5";
            label5.Size = new Size(178, 28);
            label5.TabIndex = 5;
            label5.Text = ":  عدد الساعات يومياً";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1273, 681);
            label4.Name = "label4";
            label4.Size = new Size(169, 28);
            label4.TabIndex = 4;
            label4.Text = ":  حدد مدة المراجعة";
            // 
            // BtnDelet
            // 
            BtnDelet.AutoSize = true;
            BtnDelet.BackColor = Color.Gainsboro;
            BtnDelet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDelet.Location = new Point(506, 891);
            BtnDelet.Name = "BtnDelet";
            BtnDelet.Size = new Size(144, 47);
            BtnDelet.TabIndex = 3;
            BtnDelet.Text = "\U0001f9f9 مسح";
            BtnDelet.UseVisualStyleBackColor = false;
            BtnDelet.Click += BtnDelet_Click;
            // 
            // BtnUpload
            // 
            BtnUpload.AutoSize = true;
            BtnUpload.BackColor = Color.Gainsboro;
            BtnUpload.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnUpload.ForeColor = Color.Black;
            BtnUpload.Location = new Point(1013, 523);
            BtnUpload.Name = "BtnUpload";
            BtnUpload.Size = new Size(312, 47);
            BtnUpload.TabIndex = 2;
            BtnUpload.Text = "  💾 رفع ملف ";
            BtnUpload.UseVisualStyleBackColor = false;
            BtnUpload.Click += BtnUpload_Click;
            // 
            // TxtInput
            // 
            TxtInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtInput.BackColor = Color.WhiteSmoke;
            TxtInput.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtInput.Location = new Point(839, 124);
            TxtInput.Multiline = true;
            TxtInput.Name = "TxtInput";
            TxtInput.ScrollBars = ScrollBars.Vertical;
            TxtInput.Size = new Size(603, 365);
            TxtInput.TabIndex = 1;
            TxtInput.TextChanged += TxtInput_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1109, 42);
            label3.Name = "label3";
            label3.Size = new Size(296, 28);
            label3.TabIndex = 0;
            label3.Text = ": PDF أدخل المادة أو قم برفع ملف  ";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // UC_ReviewPlan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_ReviewPlan";
            Size = new Size(1509, 1192);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumDays).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumClock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private TextBox TxtInput;
        private Label label3;
        private Button BtnUpload;
        private Label label5;
        private Label label4;
        private Button BtnDelet;
        private NumericUpDown NumClock;
        private Button BtnReview;
        private Label label6;
        private Button BtnSave;
        private OpenFileDialog openFileDialog1;
        private Label label7;
        private Label label9;
        private Label label8;
        private NumericUpDown NumDays;
        private RichTextBox TxtOutput;
        private Label label10;
        private Label label1;
    }
}
