﻿using System;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using RP3_Alarmclock.Helpers;
using RP3_Alarmclock.Models;

namespace RP3_Alarmclock.Modules
{
    class WeatherModule : TimerModule
    {
        private string ApiUrl = "api.openweathermap.org/data/2.5/weather?units=metric&id={0}&APPID={1}";

        public void UpdateWeather(object sender, object e)
        {
            var jsonText = DebugHelper.ExampleWeather();
            var data = JsonHelper.Deserialize<WeatherBase>(jsonText.Result);



            //var textBlock = controlInfo.control as TextBlock;
            //textBlock.Text = data.weather[0].description;
            
        }


        public WeatherModule(int x, int y, Grid maingrid) : base(ModuleType.Canvas, x, y, 2, 2, new SolidColorBrush(Colors.Black), new SolidColorBrush(Colors.White), maingrid)
        {
            var canvas = controlInfo.control as Canvas;

            var tb = new TextBlock();
            tb.Text = "tst";
            canvas.Children.Add(tb);


            UpdateWeather(null, null); // Inital run, since this timer only runs every 20 minutes
            InitTimer(new TimeSpan(0, 0, 20, 0, 0), UpdateWeather);
        }
    }
}
