using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static EnergySaver_CsProject.Processor;

namespace EnergySaver_CsProject
{
    
    public class ScheduledTimer
    {
        private Timer timer;
        public ScheduledTimer() { }
        public TimeSpan GetDueTime(TimeSpan currnetTime, TimeSpan endTime)
        {
            return endTime.Subtract(currnetTime);
        }
        public void SetTime(TimeSpan _time, AutoRunDelegate callback)
        {
            TimeSpan dueTime = GetDueTime(new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second), _time);
            if(dueTime < TimeSpan.Zero)
            {
                dueTime = new TimeSpan(23, 59, 59).Add(dueTime);
                dueTime.Add(new TimeSpan(0, 0, 1));
            }
            int sec = dueTime.Hours * 60 * 60 + dueTime.Minutes * 60 + dueTime.Seconds;
        }
    }
}
