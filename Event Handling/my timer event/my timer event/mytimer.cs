using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_timer_event
{
    public partial class mytimer : Component
    {
        public event EventHandler Tick;
        private CancellationTokenSource cancellationTokenSource = null;
        public mytimer()
        {
            InitializeComponent();
        }

        public mytimer(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public void Start()
        {
            if (cancellationTokenSource != null) {
                cancellationTokenSource.Cancel();
            }
            cancellationTokenSource = new CancellationTokenSource();
            Task.Run(() => work_thread(cancellationTokenSource.Token));
        }

        public void Stop()
        {
            cancellationTokenSource.Cancel();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            Tick?.Invoke(this, e);
        }

        private async Task work_thread(CancellationToken token)
        {
            while(token.IsCancellationRequested == false)
            {
                await Task.Delay(500);
                timer_tick(this, EventArgs.Empty);
            }
        }
    }
}
