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
                lbl.Location = new Point(lbl.Left + (speed * 4), lbl.Top);
                await Task.Delay(1);
            }
            lbl.Location = new Point(endX, lbl.Top);
            return $"{lbl.Text} 도착시간: {ArriveTime}초";
        }

        private async void buttonStartSeq_Click(object sender, EventArgs e)
        {
            Start();
            string logA = await MoveRacer(racerA, 5);
            string logB = await MoveRacer(racerB, 10);
            string logC = await MoveRacer(racerC, 2);
            string logD = await MoveRacer(racerD, 1);
            AddLogs(logA, logB, logC, logD);
            End();
        }

        private async void buttonStartABafterCD_Click(object sender, EventArgs e)
        {
            Start();
            var taskA = MoveRacer(racerA, 5);
            var taskB = MoveRacer(racerB, 10);
            
            string[] result = await Task.WhenAll(taskA, taskB);
            AddLogs(result);

            var taskC = MoveRacer(racerC, 2);
            var taskD = MoveRacer(racerD, 1);
            string logC = await taskC;
            string logD = await taskD;
            AddLogs(logC, logD);

            End();
        }

        private async void buttonStartAll_Click(object sender, EventArgs e)
        {
            Start();
            var taskA = MoveRacer(racerA, 5);
            var taskB = MoveRacer(racerB, 10);
            var taskC = MoveRacer(racerC, 2);
            var taskD = MoveRacer(racerD, 1);
            string[] result = await Task.WhenAll(taskA, taskB, taskC, taskD);
            AddLogs(result);
            End();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            Start();
            Task<string> tA = MoveRacer(racerA, 5);
            Task<string> tB = MoveRacer(racerB, 10);
            Task<string> tC = MoveRacer(racerC, 2);
            Task<string> tD = MoveRacer(racerD, 1);

            var tasks = new List<Task<string>>{ tA, tB, tC, tD};
            while( tasks.Count > 0 )
            {
                var t = await Task.WhenAny(tasks);
                AddLogs((string)t.Result);
                tasks.Remove(t);
            }
            End();
        }
    }
}
