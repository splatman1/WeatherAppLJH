using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherAppLJH
{
    internal class TimeConfig
    {
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }
        public static long DateTimeToUnixTimeStamp(DateTime dateTime)
        {
            long unixTime = ((DateTimeOffset)dateTime).ToUnixTimeSeconds();
            return unixTime;
        }
    }
}
