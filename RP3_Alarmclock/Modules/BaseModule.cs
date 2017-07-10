using RP3_Alarmclock.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace RP3_Alarmclock.Modules
{
    class BaseModule
    {
        protected ControlInfo controlInfo;

        protected int BlockValueToPixelValueX(int x)
        {
            return x * 200;
        }

        protected int BlockValueToPixelValueY(int y)
        {
            return y * 160;
        }

        public BaseModule(int x, int y, int width, int height, SolidColorBrush foreground, SolidColorBrush background, Grid maingrid)
        {
            controlInfo = ControlHelper.CreateTextBlock(
                BlockValueToPixelValueX(x),
                BlockValueToPixelValueY(y),
                BlockValueToPixelValueX(width),
                BlockValueToPixelValueY(height),
                foreground,
                background
                );

            maingrid.Children.Add(controlInfo.border);
        }
    }
}
