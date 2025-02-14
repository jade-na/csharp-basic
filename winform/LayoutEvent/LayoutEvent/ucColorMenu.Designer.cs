namespace LayoutEvent
{
    partial class ucColorMenu
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            pColor = new Panel();
            cDialogColor = new ColorDialog();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(pColor);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(170, 453);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(10, 10);
            label1.Margin = new Padding(10, 10, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "Color Select";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pColor
            // 
            pColor.BackColor = Color.White;
            pColor.Location = new Point(10, 45);
            pColor.Margin = new Padding(10, 10, 0, 0);
            pColor.Name = "pColor";
            pColor.Size = new Size(100, 25);
            pColor.TabIndex = 1;
            pColor.MouseClick += PColor_MouseClick1;
            // 
            // ucColorMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "ucColorMenu";
            Size = new Size(170, 453);
            Load += ucColorMenu_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Panel pColor;
        private ColorDialog cDialogColor;
    }
}
