using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace RP3_Alarmclock.Modules
{
    class AlarmModule : TimerModule
    {
        public void UpdateClock(object sender, object e)
        {


            //var textBlock = controlInfo.control as TextBlock;
            //textBlock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public AlarmModule(int x, int y, Grid maingrid) : base(ModuleType.Text, x, y, 2, 1, new SolidColorBrush(Colors.White), new SolidColorBrush(Colors.Red), maingrid)
        {
            InitTimer(new TimeSpan(0, 0, 0, 1, 0), UpdateClock);
        }
    }
}
