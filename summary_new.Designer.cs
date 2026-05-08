namespace SmartEduAssistant
{
    partial class summary_new
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnClear = new Button();
            label1 = new Label();
            lblOutput = new Label();
            lblInput = new Label();
            RtxtOutput = new RichTextBox();
            rtxtInput = new RichTextBox();
            btnSavePDF = new Button();
            btnSummary = new Button();
            btnUploadPDF = new Button();
            PnlTitle = new Panel();
            lblTitle = new Label();
            lblBottom = new Label();
            PnlBottom = new Panel();
            labelBottom = new Label();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            PnlTitle.SuspendLayout();
            PnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblOutput);
            panel1.Controls.Add(lblInput);
            panel1.Controls.Add(RtxtOutput);
            panel1.Controls.Add(rtxtInput);
            panel1.Controls.Add(btnSavePDF);
            panel1.Controls.Add(btnSummary);
            panel1.Controls.Add(btnUploadPDF);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(1612, 865);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gainsboro;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(566, 790);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(162, 48);
            btnClear.TabIndex = 6;
            btnClear.Text = "\U0001f9f9 مسح";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(370, 296);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 12;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutput.ForeColor = Color.Black;
            lblOutput.Location = new Point(630, 48);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(98, 28);
            lblOutput.TabIndex = 11;
            lblOutput.Text = ":  التلخيص";
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.BackColor = Color.White;
            lblInput.FlatStyle = FlatStyle.Flat;
            lblInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInput.ForeColor = Color.Black;
            lblInput.Location = new Point(1290, 39);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(248, 28);
            lblInput.TabIndex = 10;
            lblInput.Text = ": ادخل النص او قم برفع ملف ";
            // 
            // RtxtOutput
            // 
            RtxtOutput.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RtxtOutput.Location = new Point(71, 93);
            RtxtOutput.Name = "RtxtOutput";
            RtxtOutput.ReadOnly = true;
            RtxtOutput.ScrollBars = RichTextBoxScrollBars.Vertical;
            RtxtOutput.Size = new Size(701, 667);
            RtxtOutput.TabIndex = 9;
            RtxtOutput.Text = "";
            // 
            // rtxtInput
            // 
            rtxtInput.BackColor = Color.WhiteSmoke;
            rtxtInput.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxtInput.Location = new Point(901, 93);
            rtxtInput.Name = "rtxtInput";
            rtxtInput.Size = new Size(661, 550);
            rtxtInput.TabIndex = 8;
            rtxtInput.Text = "";
            // 
            // btnSavePDF
            // 
            btnSavePDF.BackColor = Color.Teal;
            btnSavePDF.FlatStyle = FlatStyle.Flat;
            btnSavePDF.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSavePDF.ForeColor = Color.FromArgb(44, 44, 44);
            btnSavePDF.Location = new Point(137, 795);
            btnSavePDF.Name = "btnSavePDF";
            btnSavePDF.Size = new Size(406, 43);
            btnSavePDF.TabIndex = 7;
            btnSavePDF.Text = " 💾 حفظ ملف";
            btnSavePDF.UseVisualStyleBackColor = false;
            btnSavePDF.Click += btnSavePDF_Click;
            // 
            // btnSummary
            // 
            btnSummary.BackColor = Color.Gainsboro;
            btnSummary.FlatStyle = FlatStyle.Flat;
            btnSummary.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSummary.Location = new Point(1044, 798);
            btnSummary.Name = "btnSummary";
            btnSummary.Size = new Size(398, 45);
            btnSummary.TabIndex = 6;
            btnSummary.Text = " 📝 لخّص";
            btnSummary.UseVisualStyleBackColor = false;
            btnSummary.Click += btnSummary_Click;
            // 
            // btnUploadPDF
            // 
            btnUploadPDF.BackColor = Color.Gainsboro;
            btnUploadPDF.FlatStyle = FlatStyle.Flat;
            btnUploadPDF.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUploadPDF.ForeColor = Color.Black;
            btnUploadPDF.Location = new Point(1103, 690);
            btnUploadPDF.Name = "btnUploadPDF";
            btnUploadPDF.Size = new Size(292, 47);
            btnUploadPDF.TabIndex = 5;
            btnUploadPDF.Text = "💾  رفع ملف ";
            btnUploadPDF.UseVisualStyleBackColor = false;
            btnUploadPDF.Click += btnUploadPDF_Click;
            // 
            // PnlTitle
            // 
            PnlTitle.BackColor = Color.Gainsboro;
            PnlTitle.Controls.Add(lblTitle);
            PnlTitle.Dock = DockStyle.Top;
            PnlTitle.Location = new Point(0, 0);
            PnlTitle.Name = "PnlTitle";
            PnlTitle.Size = new Size(1612, 86);
            PnlTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Right;
            lblTitle.FlatStyle = FlatStyle.Flat;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(44, 44, 44);
            lblTitle.Location = new Point(1412, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = " تلخيص الدروس";
            // 
            // lblBottom
            // 
            lblBottom.AutoSize = true;
            lblBottom.Dock = DockStyle.Bottom;
            lblBottom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBottom.Location = new Point(0, 39);
            lblBottom.Name = "lblBottom";
            lblBottom.Size = new Size(0, 28);
            lblBottom.TabIndex = 1;
            // 
            // PnlBottom
            // 
            PnlBottom.BackColor = Color.Gainsboro;
            PnlBottom.Controls.Add(labelBottom);
            PnlBottom.Controls.Add(lblBottom);
            PnlBottom.Dock = DockStyle.Bottom;
            PnlBottom.Location = new Point(0, 951);
            PnlBottom.Name = "PnlBottom";
            PnlBottom.Size = new Size(1612, 67);
            PnlBottom.TabIndex = 4;
            // 
            // labelBottom
            // 
            labelBottom.AutoSize = true;
            labelBottom.Dock = DockStyle.Bottom;
            labelBottom.FlatStyle = FlatStyle.Flat;
            labelBottom.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBottom.ForeColor = Color.FromArgb(44, 44, 44);
            labelBottom.Location = new Point(0, 11);
            labelBottom.Name = "labelBottom";
            labelBottom.Size = new Size(255, 28);
            labelBottom.TabIndex = 2;
            labelBottom.Text = "SmartEduAssistant © 2025";
            labelBottom.TextAlign = ContentAlignment.BottomLeft;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // summary_new
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(PnlTitle);
            Controls.Add(PnlBottom);
            Name = "summary_new";
            Size = new Size(1612, 1018);
            Load += summary_new_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PnlTitle.ResumeLayout(false);
            PnlTitle.PerformLayout();
            PnlBottom.ResumeLayout(false);
            PnlBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblOutput;
        private Label lblInput;
        private RichTextBox RtxtOutput;
        private RichTextBox rtxtInput;
        private Button btnSavePDF;
        private Button btnSummary;
        private Button btnUploadPDF;
        private Panel PnlTitle;
        private Label lblTitle;
        private Label lblBottom;
        private Panel PnlBottom;
        private Label labelBottom;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Button btnClear;
    }
}