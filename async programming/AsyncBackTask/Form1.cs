using System.Diagnostics;

namespace AsyncBackTask
{
    public partial class Form1 : Form
    {
        Stopwatch sw = new Stopwatch();
        private double ArriveTime => Math.Round(sw.ElapsedMilliseconds / 1000d, 2);
        private int racer_start;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            racer_start = racerA.Left;
        }

        private void Start()
        {
            sw.Start();
            ClearLog();
            ResetRacers();
        }

        private void End()
        {
            AddLogs($"총 소요시간 : {ArriveTime}초");
            sw.Stop();
            sw.Reset();
        }

        private void AddLogs(params string[] logs) => lbLog.Items.AddRange(logs);

        private void ResetRacers()
        {
            var racers = new List<Label> { racerA, racerB, racerC, racerD };
            foreach (var racer in racers)
            {
                racer.Left = racer_start;
            }
        }

        private void ClearLog()
        {
            lbLog.Items.Clear();
        }

        private async Task<string> MoveRacer(Label lbl, int speed)
        {
            int endX = FinishLine.Left - lbl.Width;
            while (lbl.Left < endX)
            {
                lbl.Location = new Point(lbl.Left * speed * 4, lbl.Top);
                await Task.Delay(500);
            }
            lbl.Location = new Point(endX, lbl.Top);
            return $"{lbl.Text} 도착시간: {ArriveTime}초";
        }

        private async void buttonStartSeq_Click(object sender, EventArgs e)
        {
            Start();
            await MoveRacer(racerA, 10);
            await MoveRacer(racerB, 30);
            await MoveRacer(racerC, 5);
            await MoveRacer(racerD, 1);
            End();
        }

        private void buttonStartABafterCD_Click(object sender, EventArgs e)
        {

        }

        private void buttonStartAll_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}