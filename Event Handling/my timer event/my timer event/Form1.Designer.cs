namespace my_timer_event
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
            listBox1 = new ListBox();
            button_start = new Button();
            button_stop = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(73, 112);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(680, 289);
            listBox1.TabIndex = 0;
            // 
            // button_start
            // 
            button_start.Location = new Point(77, 22);
            button_start.Name = "button_start";
            button_start.Size = new Size(104, 52);
            button_start.TabIndex = 1;
            button_start.Text = "start";
            button_start.UseVisualStyleBackColor = true;
            button_start.Click += button_start_Click;
            // 
            // button_stop
            // 
            button_stop.Location = new Point(225, 22);
            button_stop.Name = "button_stop";
            button_stop.Size = new Size(104, 52);
            button_stop.TabIndex = 2;
            button_stop.Text = "stop";
            button_stop.UseVisualStyleBackColor = true;
            button_stop.Click += button_stop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_stop);
            Controls.Add(button_start);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button_start;
        private Button button_stop;
    }
}
