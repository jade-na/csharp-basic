using System.Windows.Forms;

namespace my_timer_event
{
    public partial class Form1 : Form
    {
        private mytimer timer1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1 = new mytimer();
            timer1.Tick += Timer1_tick;

        }

        private void Timer1_tick(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => Timer1_tick(sender, e)));
            }
            else
            {
                listBox1.Items.Add("Timer ticked");
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
