using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Задание_1_28._06._2022
{
    class Secundomer
    {
        private DispatcherTimer timer;
        private Stopwatch stopwatch;
        private string currentTime;
        public delegate void gg(string s);
        public event gg Update;
        public Secundomer()
        {
            timer = new DispatcherTimer();
            stopwatch = new Stopwatch();
            currentTime = string.Empty;
        }
        public void Reset()
        {
            Stop();
            timer = new DispatcherTimer();
            stopwatch = new Stopwatch();
            currentTime = string.Empty;
        }
        public void Start()
        {
            if (!timer.IsEnabled)
            {
                timer.Interval = new TimeSpan(0, 0, 1);
                timer.Tick += Timer_Tick;
                timer.Start();
                stopwatch.Start();
            }
        }
        public void Stop()
        {
            if (timer.IsEnabled)
            {
                timer.Stop();
                stopwatch.Stop();
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                TimeSpan ts = stopwatch.Elapsed;
                currentTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
                Update(currentTime);
                
            }
        }
       
    }
}
