namespace LayoutEvent
{
    partial class ucPanel
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
            lblPanel = new Label();
            SuspendLayout();
            // 
            // lblPanel
            // 
            lblPanel.Dock = DockStyle.Fill;
            lblPanel.Location = new Point(0, 0);
            lblPanel.Name = "lblPanel";
            lblPanel.Size = new Size(200, 180);
            lblPanel.TabIndex = 0;
            lblPanel.Text = "(0, 0)";
            lblPanel.TextAlign = ContentAlignment.MiddleCenter;
            lblPanel.MouseDoubleClick += lblPanel_MouseDoubleClick;
            // 
            // ucPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPanel);
            Name = "ucPanel";
            Size = new Size(200, 180);
            Resize += ucPanel_Resize;
            ResumeLayout(false);
        }

        #endregion

        private Label lblPanel;
    }
}
