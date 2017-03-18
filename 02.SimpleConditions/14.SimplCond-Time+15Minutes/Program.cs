using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.SimplCond_Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int allInMinutes = (hours * 60 + minutes)+15;
            int allHours = allInMinutes / 60;
            int allMinutes = allInMinutes % 60;
            if (allHours>=24)
            {
                Console.WriteLine("{0}:{1:d2}",(allHours-24),allMinutes);
            }
            else
            {
                Console.WriteLine("{0}:{1:d2}",allHours,allMinutes);
            }
        }
    }
}
