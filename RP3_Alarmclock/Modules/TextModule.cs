using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace RP3_Alarmclock.Modules
{
    class TextModule : BaseModule
    {
        public TextModule(int x, int y, int width, int height, string text, SolidColorBrush foreground, SolidColorBrush background, Grid maingrid) : base(ModuleType.Text, x, y, width, height, foreground, background, maingrid)
        {
            var textBlock = controlInfo.control as TextBlock;
            textBlock.Text = text;

        }
    }
}