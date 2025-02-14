namespace LayoutEvent
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
            splitContainer1 = new SplitContainer();
            ucColorMenu1 = new ucColorMenu();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ucPanel2 = new ucPanel();
            ucPanel3 = new ucPanel();
            ucPanel4 = new ucPanel();
            ucPanel1 = new ucPanel();
            lboxLog = new ListBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(ucColorMenu1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(918, 630);
            splitContainer1.SplitterDistance = 120;
            splitContainer1.TabIndex = 0;
            // 
            // ucColorMenu1
            // 
            ucColorMenu1.Dock = DockStyle.Fill;
            ucColorMenu1.Location = new Point(0, 0);
            ucColorMenu1.Name = "ucColorMenu1";
            ucColorMenu1.Size = new Size(120, 630);
            ucColorMenu1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(ucPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(lboxLog, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.Size = new Size(794, 630);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(ucPanel2, 0, 0);
            tableLayoutPanel2.Controls.Add(ucPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(ucPanel4, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 103);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(788, 444);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // ucPanel2
            // 
            ucPanel2.BackColor = Color.FromArgb(255, 224, 192);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(3, 3);
            ucPanel2.Name = "ucPanel2";
            tableLayoutPanel2.SetRowSpan(ucPanel2, 2);
            ucPanel2.Size = new Size(388, 438);
            ucPanel2.TabIndex = 0;
            // 
            // ucPanel3
            // 
            ucPanel3.BackColor = Color.FromArgb(192, 255, 255);
            ucPanel3.Dock = DockStyle.Fill;
            ucPanel3.Location = new Point(397, 3);
            ucPanel3.Name = "ucPanel3";
            ucPanel3.Size = new Size(388, 216);
            ucPanel3.TabIndex = 1;
            // 
            // ucPanel4
            // 
            ucPanel4.BackColor = Color.FromArgb(192, 255, 192);
            ucPanel4.Dock = DockStyle.Fill;
            ucPanel4.Location = new Point(397, 225);
            ucPanel4.Name = "ucPanel4";
            ucPanel4.Size = new Size(388, 216);
            ucPanel4.TabIndex = 2;
            ucPanel4.Load += ucPanel4_Load;
            // 
            // ucPanel1
            // 
            ucPanel1.BackColor = Color.FromArgb(255, 192, 192);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.ForeColor = Color.White;
            ucPanel1.Location = new Point(3, 3);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(788, 94);
            ucPanel1.TabIndex = 1;
            // 
            // lboxLog
            // 
            lboxLog.Dock = DockStyle.Fill;
            lboxLog.FormattingEnabled = true;
            lboxLog.ItemHeight = 15;
            lboxLog.Location = new Point(3, 553);
            lboxLog.Name = "lboxLog";
            lboxLog.Size = new Size(788, 74);
            lboxLog.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 630);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private ucColorMenu ucColorMenu1;
        private TableLayoutPanel tableLayoutPanel2;
        private ucPanel ucPanel1;
        private ucPanel ucPanel2;
        private ucPanel ucPanel3;
        private ucPanel ucPanel4;
        private ListBox lboxLog;
    }
}
