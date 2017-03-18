using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string day = "";
            if (num <= 0 || num > 7)
            {
                Console.WriteLine("Error");
            }
            else
            {
                switch (num)
                {
                    case 1:
                        day = "Monday";
                        break;
                    case 2:
                        day = "Tuesday";
                        break;
                    case 3:
                        day = "Wednesday";
                        break;
                    case 4:
                        day = "Thursday";
                        break;
                    case 5:
                        day = "Friday";
                        break;
                    case 6:
                        day = "Saturday";
                        break;
                    case 7:
                        day = "Sunday";
                        break;
                }
                Console.WriteLine(day);
            }
        }
    }
}
