namespace Log4Net_Example
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            rdoFatal = new RadioButton();
            rdoError = new RadioButton();
            rdoWarn = new RadioButton();
            rdoDebug = new RadioButton();
            rdoInfo = new RadioButton();
            groupBox2 = new GroupBox();
            btnLogging = new Button();
            tboxLog = new TextBox();
            groupBox3 = new GroupBox();
            rtbLogging = new RichTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoFatal);
            groupBox1.Controls.Add(rdoError);
            groupBox1.Controls.Add(rdoWarn);
            groupBox1.Controls.Add(rdoDebug);
            groupBox1.Controls.Add(rdoInfo);
            groupBox1.Location = new Point(38, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(570, 97);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // rdoFatal
            // 
            rdoFatal.AutoSize = true;
            rdoFatal.Location = new Point(364, 42);
            rdoFatal.Name = "rdoFatal";
            rdoFatal.Size = new Size(48, 19);
            rdoFatal.TabIndex = 4;
            rdoFatal.TabStop = true;
            rdoFatal.Text = "fatal";
            rdoFatal.UseVisualStyleBackColor = true;
            // 
            // rdoError
            // 
            rdoError.AutoSize = true;
            rdoError.Location = new Point(277, 42);
            rdoError.Name = "rdoError";
            rdoError.Size = new Size(50, 19);
            rdoError.TabIndex = 3;
            rdoError.TabStop = true;
            rdoError.Text = "error";
            rdoError.UseVisualStyleBackColor = true;
            // 
            // rdoWarn
            // 
            rdoWarn.AutoSize = true;
            rdoWarn.Location = new Point(201, 42);
            rdoWarn.Name = "rdoWarn";
            rdoWarn.Size = new Size(51, 19);
            rdoWarn.TabIndex = 2;
            rdoWarn.TabStop = true;
            rdoWarn.Text = "warn";
            rdoWarn.UseVisualStyleBackColor = true;
            // 
            // rdoDebug
            // 
            rdoDebug.AutoSize = true;
            rdoDebug.Location = new Point(99, 42);
            rdoDebug.Name = "rdoDebug";
            rdoDebug.Size = new Size(59, 19);
            rdoDebug.TabIndex = 1;
            rdoDebug.TabStop = true;
            rdoDebug.Text = "debug";
            rdoDebug.UseVisualStyleBackColor = true;
            // 
            // rdoInfo
            // 
            rdoInfo.AutoSize = true;
            rdoInfo.Location = new Point(30, 42);
            rdoInfo.Name = "rdoInfo";
            rdoInfo.Size = new Size(46, 19);
            rdoInfo.TabIndex = 0;
            rdoInfo.TabStop = true;
            rdoInfo.Text = "info";
            rdoInfo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLogging);
            groupBox2.Controls.Add(tboxLog);
            groupBox2.Location = new Point(38, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(574, 99);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btnLogging
            // 
            btnLogging.Location = new Point(468, 38);
            btnLogging.Name = "btnLogging";
            btnLogging.Size = new Size(100, 24);
            btnLogging.TabIndex = 4;
            btnLogging.Text = "write log";
            btnLogging.UseVisualStyleBackColor = true;
            btnLogging.Click += btnLogging_Click;
            // 
            // tboxLog
            // 
            tboxLog.Location = new Point(10, 38);
            tboxLog.Name = "tboxLog";
            tboxLog.Size = new Size(448, 23);
            tboxLog.TabIndex = 3;
            tboxLog.KeyUp += textBox1_KeyUp;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rtbLogging);
            groupBox3.Location = new Point(39, 234);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(574, 264);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // rtbLogging
            // 
            rtbLogging.Location = new Point(10, 42);
            rtbLogging.Name = "rtbLogging";
            rtbLogging.Size = new Size(543, 202);
            rtbLogging.TabIndex = 4;
            rtbLogging.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 521);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdoFatal;
        private RadioButton rdoError;
        private RadioButton rdoWarn;
        private RadioButton rdoDebug;
        private RadioButton rdoInfo;
        private GroupBox groupBox2;
        private Button btnLogging;
        private TextBox tboxLog;
        private GroupBox groupBox3;
        private RichTextBox rtbLogging;
    }
}
