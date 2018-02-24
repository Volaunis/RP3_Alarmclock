using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace RP3_Alarmclock.Modules
{
    class TimerModule : BaseModule
    {
        private DispatcherTimer _timer;

        public TimerModule(ModuleType type, int x, int y, int width, int height, SolidColorBrush foreground, SolidColorBrush background, Grid maingrid) : base(type, x, y, width, height, foreground, background, maingrid)
        {
        }

        public void InitTimer(TimeSpan intervalDelay, EventHandler<object> timerEvent)
        {
            _timer = new DispatcherTimer();
            _timer.Interval = intervalDelay;
            _timer.Tick += timerEvent;
            _timer.Start();
        }
    }
}
