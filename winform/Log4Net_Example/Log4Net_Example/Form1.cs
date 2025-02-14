using log4net;
using System.Reflection;

namespace Log4Net_Example
{
    public partial class Form1 : Form
    {
        private ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {       
            log.Info("--------------------- Start App ---------------------");
        }

        private void btnLogging_Click(object sender, EventArgs e)
        {
            fnclogging(tboxLog.Text);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                fnclogging(tboxLog.Text);
            }
        }

        /// <summary>
        /// Radio Button에 선택 된 Level과 log4net setting 값을 기준으로 Logging 하는 부분
        /// </summary>
        /// <param name="strLoggingData"></param>
        private void fnclogging(string strLoggingData)
        {
            if (rdoInfo.Checked)
            {
                log.Info(strLoggingData);
            }
            else if (rdoDebug.Checked)
            {
                log.Debug(strLoggingData);
            }
            else if (rdoWarn.Checked)
            {
                log.Warn(strLoggingData);
            }
            else if (rdoError.Checked)
            {
                log.Error(strLoggingData);
            }
            else if (rdoFatal.Checked)
            {
                log.Fatal(strLoggingData);
            }
        }
    }
}
