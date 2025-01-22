namespace AsyncBackTask
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
            panel1 = new Panel();
            button4 = new Button();
            buttonStartAll = new Button();
            buttonStartABafterCD = new Button();
            buttonStartSeq = new Button();
            racerA = new Label();
            lbLog = new ListBox();
            racerB = new Label();
            racerC = new Label();
            racerD = new Label();
            FinishLine = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(buttonStartAll);
            panel1.Controls.Add(buttonStartABafterCD);
            panel1.Controls.Add(buttonStartSeq);
            panel1.Location = new Point(18, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 286);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.Location = new Point(0, 210);
            button4.Name = "button4";
            button4.Size = new Size(174, 70);
            button4.TabIndex = 3;
            button4.Text = "ABCD 동시 출발 (WhenAny)";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // buttonStartAll
            // 
            buttonStartAll.Dock = DockStyle.Top;
            buttonStartAll.Location = new Point(0, 140);
            buttonStartAll.Name = "buttonStartAll";
            buttonStartAll.Size = new Size(174, 70);
            buttonStartAll.TabIndex = 2;
            buttonStartAll.Text = "ABCD 동시 출발";
            buttonStartAll.UseVisualStyleBackColor = true;
            buttonStartAll.Click += buttonStartAll_Click;
            // 
            // buttonStartABafterCD
            // 
            buttonStartABafterCD.Dock = DockStyle.Top;
            buttonStartABafterCD.Location = new Point(0, 70);
            buttonStartABafterCD.Name = "buttonStartABafterCD";
            buttonStartABafterCD.Size = new Size(174, 70);
            buttonStartABafterCD.TabIndex = 1;
            buttonStartABafterCD.Text = "AB출발 후 CD출발";
            buttonStartABafterCD.UseVisualStyleBackColor = true;
            buttonStartABafterCD.Click += buttonStartABafterCD_Click;
            // 
            // buttonStartSeq
            // 
            buttonStartSeq.Dock = DockStyle.Top;
            buttonStartSeq.Location = new Point(0, 0);
            buttonStartSeq.Name = "buttonStartSeq";
            buttonStartSeq.Size = new Size(174, 70);
            buttonStartSeq.TabIndex = 0;
            buttonStartSeq.Text = "하나씩 순서대로 출발";
            buttonStartSeq.UseVisualStyleBackColor = true;
            buttonStartSeq.Click += buttonStartSeq_Click;
            // 
            // racerA
            // 
            racerA.AutoSize = true;
            racerA.Font = new Font("Malgun Gothic", 38F, FontStyle.Regular, GraphicsUnit.Point);
            racerA.Location = new Point(208, 36);
            racerA.Name = "racerA";
            racerA.Size = new Size(144, 68);
            racerA.TabIndex = 1;
            racerA.Text = "A.🚗";
            // 
            // lbLog
            // 
            lbLog.FormattingEnabled = true;
            lbLog.ItemHeight = 15;
            lbLog.Location = new Point(19, 341);
            lbLog.Name = "lbLog";
            lbLog.Size = new Size(1106, 229);
            lbLog.TabIndex = 2;
            // 
            // racerB
            // 
            racerB.AutoSize = true;
            racerB.Font = new Font("Malgun Gothic", 38F, FontStyle.Regular, GraphicsUnit.Point);
            racerB.Location = new Point(208, 104);
            racerB.Name = "racerB";
            racerB.Size = new Size(140, 68);
            racerB.TabIndex = 3;
            racerB.Text = "B.🚅";
            // 
            // racerC
            // 
            racerC.AutoSize = true;
            racerC.Font = new Font("Malgun Gothic", 38F, FontStyle.Regular, GraphicsUnit.Point);
            racerC.Location = new Point(208, 178);
            racerC.Name = "racerC";
            racerC.Size = new Size(142, 68);
            racerC.TabIndex = 4;
            racerC.Text = "C.\U0001f6f5";
            // 
            // racerD
            // 
            racerD.AutoSize = true;
            racerD.Font = new Font("Malgun Gothic", 38F, FontStyle.Regular, GraphicsUnit.Point);
            racerD.Location = new Point(208, 248);
            racerD.Name = "racerD";
            racerD.Size = new Size(147, 68);
            racerD.TabIndex = 5;
            racerD.Text = "D.\U0001f6f4";
            // 
            // FinishLine
            // 
            FinishLine.BackColor = SystemColors.MenuHighlight;
            FinishLine.ForeColor = SystemColors.ControlLightLight;
            FinishLine.Location = new Point(1062, 36);
            FinishLine.Name = "FinishLine";
            FinishLine.Size = new Size(63, 286);
            FinishLine.TabIndex = 6;
            FinishLine.Text = "도착";
            FinishLine.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 577);
            Controls.Add(FinishLine);
            Controls.Add(racerD);
            Controls.Add(racerC);
            Controls.Add(racerB);
            Controls.Add(lbLog);
            Controls.Add(racerA);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button buttonStartAll;
        private Button buttonStartABafterCD;
        private Button buttonStartSeq;
        private Label racerA;
        private ListBox lbLog;
        private Label racerB;
        private Label racerC;
        private Label racerD;
        private Button FinishLine;
    }
}