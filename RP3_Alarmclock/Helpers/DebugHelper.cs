using RP3_Alarmclock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace RP3_Alarmclock.Helpers
{
    public static class DebugHelper
    {
        public static async Task<string> ExampleWeather()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(new Uri(@"ms-appx:///Example1.json"));
            return await FileIO.ReadTextAsync(file);
        }

        public static List<AlarmEvent> ExampleAlarmEvents()
        {
            return new List<AlarmEvent>
            {
                new AlarmEvent { Id=1, PlannedEventId=1, RunAt=new DateTime(2017,11,12,10,0,0) },
                new AlarmEvent {Id=2,PlannedEventId=2,RunAt=new DateTime(2017,11,12,11,10,00) }
            };
        }

        public static List<PlannedEvent> ExamplePlannedEvents()
        {
            return new List<PlannedEvent>
            {
                new PlannedEvent {ActivationTime=new TimeSpan(10,0,0),Id=1, Name="Example 1" },
                new PlannedEvent {ActivationTime=new TimeSpan(11,0,0),Id=2,Name="Example 2" }
            };
        }
    }
}
