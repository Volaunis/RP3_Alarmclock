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
    public enum ModuleType
    {
        Text,
        Canvas
    }

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

        public BaseModule(ModuleType type, int x, int y, int width, int height, SolidColorBrush foreground, SolidColorBrush background, Grid maingrid)
        {
            if (type == ModuleType.Canvas)
            {
                controlInfo = ControlHelper.CreateCanvas(
                    BlockValueToPixelValueX(x),
                    BlockValueToPixelValueY(y),
                    BlockValueToPixelValueX(width),
                    BlockValueToPixelValueY(height),
                    foreground,
                    background
                    );
            }
            else if (type == ModuleType.Text)
            {
                controlInfo = ControlHelper.CreateTextBlock(
                    BlockValueToPixelValueX(x),
                    BlockValueToPixelValueY(y),
                    BlockValueToPixelValueX(width),
                    BlockValueToPixelValueY(height),
                    foreground,
                    background
                    );
            }
            maingrid.Children.Add(controlInfo.border);
        }
    }
}
