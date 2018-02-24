using RP3_Alarmclock.Modules;
using System;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RP3_Alarmclock
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            var _mainGrid = new Grid()
            {
                Background = new SolidColorBrush(Colors.Black),
                Width = 800,
                Height = 480
            };
            Content = _mainGrid;

            var timeModule = new TimeModule(0, 0, _mainGrid);
            var dateModule = new DateModule(0, 1, _mainGrid);
            var alarmModule = new AlarmModule(2, 0, _mainGrid);
            var weatherModule = new WeatherModule(2, 1, _mainGrid);


            //var textModule1 = new TextModule(2, 0, 1, 1, "1", new SolidColorBrush(Colors.White), new SolidColorBrush(Colors.Green), _mainGrid);
            //var textModule2 = new TextModule(3, 0, 1, 1, "2", new SolidColorBrush(Colors.White), new SolidColorBrush(Colors.LightBlue), _mainGrid);
            //var textModule3 = new TextModule(0, 1, 1, 1, "3", new SolidColorBrush(Colors.White), new SolidColorBrush(Colors.Orange), _mainGrid);
            //var textModule4 = new TextModule(1, 1, 1, 1, "4", new SolidColorBrush(Colors.White), new SolidColorBrush(Colors.Teal), _mainGrid);
            var textModule5 = new TextModule(0, 2, 1, 1, "5", new SolidColorBrush(Colors.White), new SolidColorBrush(Colors.Purple), _mainGrid);
            var textModule6 = new TextModule(1, 2, 1, 1, "6", new SolidColorBrush(Colors.White), new SolidColorBrush(Colors.Gray), _mainGrid);

        }

        private void TblClock_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tblClock_KeyDown(object sender, KeyRoutedEventArgs e)
        {

        }
    }
}
