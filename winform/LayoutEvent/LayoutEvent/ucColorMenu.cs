using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LayoutEvent
{
    public partial class ucColorMenu : UserControl
    {
        // 1) Delegate Event 선언 
        public delegate void delColorSender(object oSender, Color oColor);
        public event delColorSender eventColorSender;
        // 2) 기본 이벤트 핸들러
        public event EventHandler oColorEventHandler;

        // 3) 제너릭 형태의 delegate 선언
        public event Action<object, Color> eColorAction;

        public ucColorMenu()
        {
            InitializeComponent();
        }

        private void PColor_MouseClick1(object sender, MouseEventArgs e)
        {
            DialogResult result = cDialogColor.ShowDialog();
            if (result == DialogResult.OK)
            {
                pColor.BackColor = cDialogColor.Color;
            }
        }

        private void ucColorMenu_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 5; i++) {
                Button obtn = new Button();

                obtn.Name = $"btn{i}";
                obtn.Text = $"P{i} 색상 변경";
                obtn.BackColor = Color.Gray;
                obtn.Margin = new Padding(10, 10, 0, 0);
                obtn.Size = new Size(100, 30);
                obtn.Click += Obtn_Click;

                flowLayoutPanel1.Controls.Add(obtn);
            }
        }

        private void Obtn_Click(object? sender, EventArgs e)
        {
            //eventColorSender(sender, pColor.BackColor);
            //oColorEventHandler(sender, e);
            eColorAction(sender, pColor.BackColor);
        }

        public string ChangeButtonColor(ucPanel ucPnl)
        {
            string targetBtnName = "";
            switch(ucPnl.Name)
            {
                case "ucPanel1": targetBtnName = "btn1"; break;
                case "ucPanel2": targetBtnName = "btn2"; break;
                case "ucPanel3": targetBtnName = "btn3"; break;
                case "ucPanel4": targetBtnName = "btn4"; break;
                default:
                    break;
            }

            return ChangeButtonColor_local(targetBtnName, ucPnl.BackColor, ucPnl.Name);
        }

        private string ChangeButtonColor_local(string btn_name, Color color, string pnl_name)
        {
            string result = "";

            foreach( var oitem in flowLayoutPanel1.Controls)
            {
                if (oitem is Button)
                {
                    Button obtn = oitem as Button;
                    if (obtn.Name == btn_name)
                    {
                        obtn.BackColor = color;
                        result = $"선택 : {pnl_name}, 색상 : {color.ToString()}";
                        break;
                    }
                }
            }
            return result;
        }
    }
}
