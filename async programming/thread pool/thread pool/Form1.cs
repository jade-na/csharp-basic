using System.Security.Cryptography;

namespace thread_pool
{
    public partial class Form1 : Form
    {
        static string src_fileName = "E:\\OneDrive\\books\\Visual C++ 완벽 가이드 2nd_20231016.pdf";
        static string dst_fileName = "E:\\OneDrive\\books\\Visual C++ 완벽 가이드 2nd_20231016(2).pdf";

        FileCopyUtills m_FileCopyUtill;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            m_FileCopyUtill = new FileCopyUtills();
            m_FileCopyUtill.EvtFileProgress += FileCopyProgressEventHandle;
        }

        public void FileCopyProgressEventHandle(string copyUnits, string totalUnits, int percentage)
        {
            if (this.InvokeRequired)
            {
                BeginInvoke(new FileProgressDelegate(FileCopyProgressEventHandle), copyUnits, totalUnits, percentage);
            }
            else
            {
                progressBar1.Value = percentage;
                label1.Text = $"{copyUnits} /  {totalUnits} [{percentage}%]";
            }
        }

        /*===============================================================================
         * 
         * async call and copy by main thread
         * 
        ===============================================================================*/
        private async Task FileCopyAsync_and_main_thread()
        {
            m_FileCopyUtill.Copy(src_fileName, dst_fileName);
        }

        private async void buttonFileCopyAsync_Click(object sender, EventArgs e)
        {
            await FileCopyAsync_and_main_thread();
        }

        /*===============================================================================
         * 
         * async call and copy by background thread
         * 
        ===============================================================================*/
        private async Task FileCopyAsync_and_Background_thread()
        {
            await Task.Run(() =>
            {
                m_FileCopyUtill.Copy(src_fileName, dst_fileName);
            });
        }

        private async void buttonFileCopyAsyncBack_Click(object sender, EventArgs e)
        {
            await FileCopyAsync_and_Background_thread();
        }
    }
}
