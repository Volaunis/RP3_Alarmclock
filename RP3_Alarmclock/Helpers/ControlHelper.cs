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
        public static ControlInfo CreateTextBlock(int offsetLeft, int offsetTop, int width, int height, SolidColorBrush foreground, SolidColorBrush background)
        {
            var borderWidth = 5;

            var ret = new ControlInfo();

            var border = CreateBorder(offsetLeft, offsetTop, width, height, background, borderWidth);

            var textBlock = new TextBlock();
            textBlock.Width = width - borderWidth;
            textBlock.Height = height - borderWidth;
            textBlock.FontSize = 80;
            textBlock.Padding = new Thickness(46, 0, 0, 0);
            textBlock.Foreground = foreground;

            border.Child = textBlock;

            ret.border = border;
            ret.control = textBlock;

            return ret;
        }

        public static ControlInfo CreateCanvas(int offsetLeft, int offsetTop, int width, int height, SolidColorBrush foreground, SolidColorBrush background)
        {
            var borderWidth = 5;

            var ret = new ControlInfo();

            var border = CreateBorder(offsetLeft, offsetTop, width, height, background, borderWidth);

            var canvas = new Canvas();
            canvas.Width = width - borderWidth;
            canvas.Height = height - borderWidth;
            
            border.Child = canvas;

            ret.border = border;
            ret.control = canvas;

            return ret;
        }

        private static Border CreateBorder(int offsetLeft, int offsetTop, int width, int height, SolidColorBrush background, int borderWidth)
        {
            var border = new Border();
            border.HorizontalAlignment = HorizontalAlignment.Left;
            border.VerticalAlignment = VerticalAlignment.Top;

            border.Margin = new Thickness(offsetLeft + borderWidth, offsetTop + borderWidth, borderWidth, borderWidth);
            border.Background = background;

            border.Width = width - borderWidth;
            border.Height = height - borderWidth;
            return border;
        }
    }



    public class ControlInfo
    {
        public Border border { get; set; }
        public FrameworkElement control { get; set; }
    }
}
