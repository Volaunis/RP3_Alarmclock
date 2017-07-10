using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace RP3_Alarmclock.Helpers
{
    public static class DebugHelper
    {
        public static async Task<string> ExampleWeather()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(new Uri(@"ms-appx:///Example1.json"));
            return await FileIO.ReadTextAsync(file);
        }
    }
}
