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
            Unknown,
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
            bool Within45Degrees(int specificDirection, int startDegree)
            {
                return (direction >= startDegree && direction < startDegree + 45);
            }

            // shift clockwise by 23
            // 0-<45 from NE        -   23
            // 45-<90 from E        -   68  
            // 90-<135 from SE      -   113
            // 135-<180 from S      -   158
            // 180-<225 from SW     -   203
            // 225-<270 from W      -   248
            // 270-<315 from NW     -   293
            // 315-<360 from N      -   <23 || 338

            if (direction < 23 || direction >= 338) return WindDirections.North;
            if (Within45Degrees(direction, 23)) return WindDirections.NorthEast;
            if (Within45Degrees(direction, 68)) return WindDirections.East;
            if (Within45Degrees(direction, 113)) return WindDirections.SouthEast;
            if (Within45Degrees(direction, 158)) return WindDirections.South;
            if (Within45Degrees(direction, 203)) return WindDirections.SouthWest;
            if (Within45Degrees(direction, 248)) return WindDirections.West;
            if (Within45Degrees(direction, 293)) return WindDirections.NorthWest;

            return WindDirections.Unknown;
        }
    }
}
