using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace RP3_Alarmclock.Helpers
{
    public static class ControlHelper
    {
        public static ControlInfo CreateTextBlock(int offsetLeft, int offsetTop, int width, int height, SolidColorBrush backgroundColor, SolidColorBrush foregroundColor, string text)
        {
            var ret = new ControlInfo();

            var border = new Border();
            border.HorizontalAlignment = HorizontalAlignment.Left;
            border.VerticalAlignment = VerticalAlignment.Top;

            border.Margin = new Thickness(offsetLeft, offsetTop, 0, 0);
            border.Background = backgroundColor;

            border.Width = width;
            border.Height = height;

            var textBlock = new TextBlock();
            textBlock.Text = text;
            textBlock.Width = width;
            textBlock.Height = height;
            textBlock.FontSize = 80;
            textBlock.Padding = new Thickness(46, 0, 0, 0);
            textBlock.Foreground = foregroundColor;

            border.Child = textBlock;

            ret.border = border;
            ret.control = textBlock;

            return ret;
        }
    }



    public class ControlInfo
    {
        public Border border { get; set; }
        public FrameworkElement control { get; set; }
    }
}
