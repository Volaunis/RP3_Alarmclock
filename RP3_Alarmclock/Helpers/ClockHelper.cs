using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.UI.Xaml;

namespace RP3_Alarmclock.Helpers
{
    public delegate void ClockEvent(object sender, object e);

    public class ClockHelper
    {
        private DispatcherTimer _timer;

        public ClockHelper(int interval, ClockEvent clockEvent)
        {


            _timer = new DispatcherTimer();
            _timer.Tick += ClockEvent;
        }

        void ClockEvent(object sender, object e)
        {

        }
    }
}
