using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Controllers
{
    public class DateTimeController
    {
        public static String UnixSecondsToDateTime(long timestamp)
        {
            DateTime dateTime = DateTimeOffset.FromUnixTimeSeconds(timestamp).DateTime.ToLocalTime();
            return dateTime.ToString("MMMM d, yyyy");
        }

        public static DateTime ToDateTimeUnix(long timestamp)
        {
            return DateTimeOffset.FromUnixTimeSeconds(timestamp).DateTime.ToLocalTime();
        }

        public static long FromDateToUnix(String dateTime)
        {
            DateTime date = Convert.ToDateTime(dateTime);
            return DateTimeToUnixSeconds(date);
        }

        public static long DateTimeToUnixSeconds(DateTime dateTime)
        {
            var date = new DateTime(1970, 1, 1, 0, 0, 0, dateTime.Kind);
            var unixTime = Convert.ToInt64((dateTime - date).TotalSeconds) ;

            return unixTime;
        }
    }
}
