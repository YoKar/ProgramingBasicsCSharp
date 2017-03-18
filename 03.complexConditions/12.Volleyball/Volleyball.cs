using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string LeapOrNo = Console.ReadLine();
            double hollydaysinYear = double.Parse(Console.ReadLine());
            double weekendsInHomeTown = double.Parse(Console.ReadLine());
            double allDays = 0.0;
            double weekendsInSF = ((48 - weekendsInHomeTown) * 3 / 4);
            double hollydays = (hollydaysinYear * 2 / 3);
            double leapHollidays = (weekendsInSF + weekendsInHomeTown + hollydays) * 0.15;


            if (LeapOrNo == "leap")
            {
                allDays = (weekendsInSF + weekendsInHomeTown + hollydays) + leapHollidays;
            }
            else
            {
                allDays = weekendsInHomeTown + weekendsInSF + hollydays;
            }
            Console.WriteLine(Math.Floor(allDays));
        }
    }
}
