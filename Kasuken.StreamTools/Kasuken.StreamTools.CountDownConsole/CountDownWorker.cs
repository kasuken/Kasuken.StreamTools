using System;
using System.Collections.Generic;
using System.Text;

namespace Kasuken.StreamTools.CountDownConsole
{
    internal class CountdownWorker
    {
        public int TotalSeconds { get; private set; }

        public void Tick()
        {
            TotalSeconds--;
        }

        public string FormatResult()
        {
            var t = TimeSpan.FromSeconds(TotalSeconds);

            var formattedTime = string.Format("{0:D2}h:{1:D2}m:{2:D2}s",
                            t.Hours,
                            t.Minutes,
                            t.Seconds);

            return formattedTime;
        }

        internal void Start(int seconds)
        {
            TotalSeconds = seconds;
        }
    }
}
