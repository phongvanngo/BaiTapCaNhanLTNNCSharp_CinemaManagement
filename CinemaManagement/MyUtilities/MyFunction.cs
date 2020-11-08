using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.MyUtilities
{
    public static class MyFunction
    {
        public static string ConvertString(object s)
        {
            if (s != null) return s.ToString(); else return "";
        }

        public static int MinuteToHourAndMinute(int min,out int minute)
        {
            minute = min % 60;
            return min / 60;
        }
    }
}
