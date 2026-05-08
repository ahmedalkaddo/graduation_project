namespace SmartEduAssistant
{
    partial class UC_QuestionGenerator
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
            label4 = new Label();
            panel5 = new Panel();
            rtxtOutput = new RichTextBox();
            btnClear = new Button();
            btnSave = new Button();
            btnCoppy = new Button();
            label9 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            combTypeQustion = new ComboBox();
            combLevelQustion = new ComboBox();
            numeNumberofQustion = new NumericUpDown();
            button3 = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnUpload1 = new Button();
            label2 = new Label();
            txtInput = new TextBox();
            panel2 = new Panel();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numeNumberofQustion).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(246, 28);
            label4.TabIndex = 0;
            label4.Text = "SmartEduAssistant © 2025";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 1045);
            panel5.Name = "panel5";
            panel5.Size = new Size(1482, 65);
            panel5.TabIndex = 4;
            // 
            // rtxtOutput
            // 
            rtxtOutput.BackColor = Color.WhiteSmoke;
            rtxtOutput.BorderStyle = BorderStyle.FixedSingle;
            rtxtOutput.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxtOutput.Location = new Point(34, 78);
            rtxtOutput.Name = "rtxtOutput";
            rtxtOutput.ReadOnly = true;
            rtxtOutput.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtxtOutput.Size = new Size(651, 822);
            rtxtOutput.TabIndex = 1;
            rtxtOutput.Text = "";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gainsboro;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(34, 925);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(162, 48);
            btnClear.TabIndex = 0;
            btnClear.Text = "\U0001f9f9 مسح";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.CadetBlue;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(421, 925);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(182, 48);
            btnSave.TabIndex = 4;
            btnSave.Text = "💾 حفظ ملف";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCoppy
            // 
            btnCoppy.BackColor = Color.Gainsboro;
            btnCoppy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCoppy.Location = new Point(227, 925);
            btnCoppy.Name = "btnCoppy";
            btnCoppy.Size = new Size(179, 48);
            btnCoppy.TabIndex = 5;
            btnCoppy.Text = "📋 نسخ";
            btnCoppy.UseVisualStyleBackColor = false;
            btnCoppy.Click += button6_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(514, 33);
            label9.Name = "label9";
            label9.Size = new Size(137, 28);
            label9.TabIndex = 0;
            label9.Text = ": الاسئلة الناتجة";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(1324, 641);
            label5.Name = "label5";
            label5.Size = new Size(118, 28);
            label5.TabIndex = 0;
            label5.Text = ":  نوع الاسئلة";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(952, 641);
            label6.Name = "label6";
            label6.Size = new Size(251, 28);
            label6.TabIndex = 1;
            label6.Text = ":  عدد الاسئلة (من 1 الى 100)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(1161, 893);
            label7.Name = "label7";
            label7.Size = new Size(150, 28);
            label7.TabIndex = 2;
            label7.Text = ":  مستوى الاسئلة";
            // 
            // combTypeQustion
            // 
            combTypeQustion.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combTypeQustion.FormattingEnabled = true;
            combTypeQustion.Items.AddRange(new object[] { "فراغات", "تعداد", "تعاريف", "صح وخطأ", "اختيارات", "شرح" });
            combTypeQustion.Location = new Point(1267, 709);
            combTypeQustion.Name = "combTypeQustion";
            combTypeQustion.Size = new Size(189, 33);
            combTypeQustion.TabIndex = 3;
            // 
            // combLevelQustion
            // 
            combLevelQustion.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combLevelQustion.FormattingEnabled = true;
            combLevelQustion.Items.AddRange(new object[] { "صعب ", "متوسط ", "سهل" });
            combLevelQustion.Location = new Point(723, 709);
            combLevelQustion.Name = "combLevelQustion";
            combLevelQustion.Size = new Size(196, 33);
            combLevelQustion.TabIndex = 4;
            // 
            // numeNumberofQustion
            // 
            numeNumberofQustion.Location = new Point(1021, 714);
            numeNumberofQustion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numeNumberofQustion.Name = "numeNumberofQustion";
            numeNumberofQustion.Size = new Size(120, 27);
            numeNumberofQustion.TabIndex = 5;
            numeNumberofQustion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button3
            // 
            button3.BackColor = Color.CadetBlue;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(851, 824);
            button3.Name = "button3";
            button3.Size = new Size(516, 48);
            button3.TabIndex = 6;
            button3.Text = "⚡ توليد الأسئلة";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnUpload1
            // 
            btnUpload1.BackColor = Color.Gainsboro;
            btnUpload1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpload1.Location = new Point(926, 482);
            btnUpload1.Name = "btnUpload1";
            btnUpload1.Size = new Size(366, 48);
            btnUpload1.TabIndex = 1;
            btnUpload1.Text = " 📂 رفع ملف";
            btnUpload1.UseVisualStyleBackColor = false;
            btnUpload1.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1184, 39);
            label2.Name = "label2";
            label2.Size = new Size(244, 28);
            label2.TabIndex = 0;
            label2.Text = "  :  ادخل النص او ارفع ملف   ";
            label2.Click += label2_Click;
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtInput.BackColor = Color.WhiteSmoke;
            txtInput.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.Location = new Point(774, 78);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.ScrollBars = ScrollBars.Vertical;
            txtInput.Size = new Size(685, 348);
            txtInput.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(combLevelQustion);
            panel2.Controls.Add(numeNumberofQustion);
            panel2.Controls.Add(combTypeQustion);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(btnUpload1);
            panel2.Controls.Add(rtxtOutput);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnCoppy);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(txtInput);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20);
            panel2.Size = new Size(1482, 976);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(742, 641);
            label3.Name = "label3";
            label3.Size = new Size(145, 28);
            label3.TabIndex = 7;
            label3.Text = ": مستوى الاسئلة";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1324, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 38);
            label1.TabIndex = 1;
            label1.Text = "توليد الاسئلة";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1482, 69);
            panel1.TabIndex = 0;
            // 
            // UC_QuestionGenerator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Name = "UC_QuestionGenerator";
            Size = new Size(1482, 1110);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numeNumberofQustion).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Panel panel5;
        private RichTextBox rtxtOutput;
        private Button btnClear;
        private Button btnSave;
        private Button btnCoppy;
        private Label label9;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox combTypeQustion;
        private ComboBox combLevelQustion;
        private NumericUpDown numeNumberofQustion;
        private Button button3;
        private OpenFileDialog openFileDialog1;
        private Button btnUpload1;
        private Label label2;
        private TextBox txtInput;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Label label3;
    }
}
