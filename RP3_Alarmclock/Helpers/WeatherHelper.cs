using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP3_Alarmclock.Helpers
{
    public static class WeatherHelper
    {
        public enum WindDirections
        {
            North,
            South,
            West,
            East,
            NorthWest,
            NorthEast,
            SouthWest,
            SouthEast
        }

        public static WindDirections WindDirection(int direction)
        {
            if(direction>292)
            {

            }

            return WindDirections.East;
        }
    }
}
