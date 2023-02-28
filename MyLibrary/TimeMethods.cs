using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class TimeMethods
    {
        public static double ConvertToHours(int seconds)
        {
            double secs;
            double mins;
            double Hrs;
            double result;
            int constant = 60;

            //getting minutes
            mins = seconds / constant;
            //getting hours
            result = mins / constant;
            return result;

        }
        public static double ConvertToMinutes(int seconds)
        {
            double mins;
            double result;
            int constant = 60;

            //getting minutes
            result = seconds / constant;
            return result;

        }
        public double ConvertToSeconds(int seconds)
        {
            double secs;
            double mins;
            double Hrs;
            double result;
            int constant = 60;

            //getting minutes
            mins = seconds / constant;
            //getting hours
            result = mins / constant;
            return result;

        }
    }
}
