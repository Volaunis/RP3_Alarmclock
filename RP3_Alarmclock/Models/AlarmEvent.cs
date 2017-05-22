using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP3_Alarmclock.Models
{
    class AlarmEvent
    {
        public TimeSpan RunAt { get; set; }
        public DateTime NextRunAt { get; set; }
        public string Name { get; set; }

    }
}
