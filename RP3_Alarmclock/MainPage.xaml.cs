using RP3_Alarmclock.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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

        public MainPage()
        {
            this.InitializeComponent();


            _timer = new DispatcherTimer();
            _timer.Tick += ClockEvent;
            _timer.Interval = new TimeSpan(0, 0, 1);
            _timer.Start();
        }

        private void tblClock_KeyDown(object sender, KeyRoutedEventArgs e)
        {

        }

        private void ClockEvent(object sender, object e)
        {
            tblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

    }
}
