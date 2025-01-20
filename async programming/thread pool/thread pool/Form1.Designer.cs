namespace thread_pool
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
            buttonFileCopyAsync = new Button();
            buttonFileCopyAsyncBack = new Button();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // buttonFileCopyAsync
            // 
            buttonFileCopyAsync.Location = new Point(62, 48);
            buttonFileCopyAsync.Name = "buttonFileCopyAsync";
            buttonFileCopyAsync.Size = new Size(131, 49);
            buttonFileCopyAsync.TabIndex = 0;
            buttonFileCopyAsync.Text = "비동기 파일 복사";
            buttonFileCopyAsync.UseVisualStyleBackColor = true;
            buttonFileCopyAsync.Click += buttonFileCopyAsync_Click;
            // 
            // buttonFileCopyAsyncBack
            // 
            buttonFileCopyAsyncBack.Location = new Point(216, 48);
            buttonFileCopyAsyncBack.Name = "buttonFileCopyAsyncBack";
            buttonFileCopyAsyncBack.Size = new Size(131, 49);
            buttonFileCopyAsyncBack.TabIndex = 1;
            buttonFileCopyAsyncBack.Text = "비동기 파일 복사 (백그라운드)";
            buttonFileCopyAsyncBack.UseVisualStyleBackColor = true;
            buttonFileCopyAsyncBack.Click += buttonFileCopyAsyncBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 217);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(43, 150);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(420, 42);
            progressBar1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 351);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(buttonFileCopyAsyncBack);
            Controls.Add(buttonFileCopyAsync);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFileCopyAsync;
        private Button buttonFileCopyAsyncBack;
        private Label label1;
        private ProgressBar progressBar1;
    }
}
