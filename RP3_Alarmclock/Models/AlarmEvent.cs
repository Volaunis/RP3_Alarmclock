using System;

namespace RP3_Alarmclock.Models
{
    public enum AlarmStatus
    {
        None,
        NotStarted,
        Running,
        Completed
    }

    public class AlarmEvent
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime RunAt { get; set; }
        public AlarmStatus Status { get; set; }
        public long PlannedEventId { get; set; }
    }
}
