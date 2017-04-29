using RP3_Alarmclock.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RP3_Alarmclock
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private DispatcherTimer _timer;

        private Grid _mainGrid;

        private TextBlock tblClock;

        public MainPage()
        {
            this.InitializeComponent();


            _timer = new DispatcherTimer();
            _timer.Tick += ClockEvent;
            _timer.Interval = new TimeSpan(0, 0, 1);
            _timer.Start();

            _mainGrid = new Grid();
            _mainGrid.Background = new SolidColorBrush(Colors.Black);
            _mainGrid.Width = 800;
            _mainGrid.Height = 480;

            Content = _mainGrid;
            
            //var textBlock = ControlHelper.CreateTextBlock(393, 10, 397, 123, new SolidColorBrush(Colors.Red), new SolidColorBrush(Colors.White), "");
            //textBlock.control.KeyDown += tblClock_KeyDown;
            //_mainGrid.Children.Add(textBlock.border);
            //tblClock = textBlock.control as TextBlock;


            var textBlock1 = ControlHelper.CreateTextBlock(0, 0, 200,160, new SolidColorBrush(Colors.Green), new SolidColorBrush(Colors.White), "1");
            _mainGrid.Children.Add(textBlock1.border);

            var textBlock2 = ControlHelper.CreateTextBlock(0, 160, 200,160, new SolidColorBrush(Colors.Yellow), new SolidColorBrush(Colors.White), "2");
            _mainGrid.Children.Add(textBlock2.border);

            var textBlock3 = ControlHelper.CreateTextBlock(0, 320, 200,160, new SolidColorBrush(Colors.Blue), new SolidColorBrush(Colors.White), "3");
            _mainGrid.Children.Add(textBlock3.border);

            var textBlock1a = ControlHelper.CreateTextBlock(200, 0, 200,160, new SolidColorBrush(Colors.Green), new SolidColorBrush(Colors.White), "1");
            _mainGrid.Children.Add(textBlock1a.border);

            var textBlock1b = ControlHelper.CreateTextBlock(400, 0, 200,160, new SolidColorBrush(Colors.Green), new SolidColorBrush(Colors.White), "1");
            _mainGrid.Children.Add(textBlock1b.border);

            var textBlock1c = ControlHelper.CreateTextBlock(600, 0, 200,160, new SolidColorBrush(Colors.Green), new SolidColorBrush(Colors.White), "1");
            _mainGrid.Children.Add(textBlock1c.border);

        }

        private void TblClock_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tblClock_KeyDown(object sender, KeyRoutedEventArgs e)
        {

        }

        private void ClockEvent(object sender, object e)
        {
            //tblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

    }
}
