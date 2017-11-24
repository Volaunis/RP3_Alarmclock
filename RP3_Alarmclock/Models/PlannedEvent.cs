using System;

namespace RP3_Alarmclock.Models
{
    public class PlannedEvent
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public TimeSpan ActivationTime { get; set; }


    }
}
