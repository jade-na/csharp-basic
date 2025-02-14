namespace LayoutEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ucPanel4_Load(object sender, EventArgs e)
        {
            ucColorMenu1.eColorAction += UcColorMenu1_eColorAction;
            ucPanel1.eLabelDoubleClick += UcPanel_eLabelDoubleClick;
            ucPanel2.eLabelDoubleClick += UcPanel_eLabelDoubleClick;
            ucPanel3.eLabelDoubleClick += UcPanel_eLabelDoubleClick;
            ucPanel4.eLabelDoubleClick += UcPanel_eLabelDoubleClick;
        }

        private void UcPanel_eLabelDoubleClick(object? sender, EventArgs e)
        {
            string result = ucColorMenu1.ChangeButtonColor((ucPanel)sender);
            lboxLog.Items.Add(result);  
        }

        private void UcColorMenu1_eColorAction(object arg1, Color arg2)
        {
            Button btn = arg1 as Button;
            string strPanelName = btn.Name;
            switch(strPanelName)
            {
                case "btn1":
                    ucPanel1.BackColor = arg2;
                    break;
                case "btn2":
                    ucPanel2.BackColor = arg2;
                    break;
                case "btn3":
                    ucPanel3.BackColor = arg2;
                    break;
                case "btn4":
                    ucPanel4.BackColor = arg2;
                    break;
            }
            string strResult = string.Format("선택 : {0}, 색상 : {1}", strPanelName, arg2.ToString());
            lboxLog.Items.Add(strResult);
        }

    }
}
