﻿using Newtonsoft.Json;

namespace RP3_Alarmclock.Helpers
{
    public static class JsonHelper
    {
        public static T Deserialize<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }

        public static string Serialize(object value)
        {
            return JsonConvert.SerializeObject(value);
        }
    }
}
