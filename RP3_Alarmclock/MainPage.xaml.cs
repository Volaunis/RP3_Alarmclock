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

            //var border = new Border();
            //border.HorizontalAlignment = HorizontalAlignment.Left;
            //border.VerticalAlignment = VerticalAlignment.Top;

            //border.Margin = new Thickness(393, 10, 0, 0);
            //border.Background = new SolidColorBrush(Colors.Red);

            //border.Width = 397;
            //border.Height = 123;


            //_mainGrid.Children.Add(border);

            //tblClock = new TextBlock();
            //tblClock.Text = "";
            //tblClock.Width = 397;
            //tblClock.Height = 123;
            //tblClock.FontSize = 80;
            //tblClock.Padding = new Thickness(46, 0, 0, 0);
            //tblClock.KeyDown += TblClock_KeyDown;

            //border.Child = tblClock;

            var textBlock = ControlHelper.CreateTextBlock(393, 10, 397, 123, new SolidColorBrush(Colors.Red), new SolidColorBrush(Colors.White), "");
            textBlock.control.KeyDown += tblClock_KeyDown;
            _mainGrid.Children.Add(textBlock.border);


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
            ((TextBlock)sender).Text = DateTime.Now.ToString("HH:mm:ss");
        }

    }
}
