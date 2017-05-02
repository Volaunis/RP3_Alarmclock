using System;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace RP3_Alarmclock.Modules
{
    class WeatherModule : TimerModule
    {
        private string ApiUrl = "api.openweathermap.org/data/2.5/weather?id={0}&APPID={1}";

        public void UpdateWeather(object sender, object e)
        {
            
        }


        public WeatherModule(int x, int y, Grid maingrid) : base(x,y,2,2,new SolidColorBrush(Colors.Black),new SolidColorBrush(Colors.White),maingrid)
        {
            UpdateWeather(null, null); // Inital run, since this timer only runs every 20 minutes
            InitTimer(new TimeSpan(0, 0, 20, 0, 0), UpdateWeather);
        }
    }
}
