using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.SimplCondExams_PriceForTransporte
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string dayORnight = Console.ReadLine().ToLower();
            double taxi = 0;
            double bus = 0;
            double train = 0;
            if (dayORnight == "day")
            {
                if (n >= 0 && n < 20)
                {
                    taxi = 0.70 + (0.79 * n);
                    Console.WriteLine(taxi);
                }
                else if (n >= 20 && n < 100)
                {
                    bus = 0.09 * n;
                    Console.WriteLine(bus);
                }
                else if (n >= 100)
                {
                    train = 0.06 * n;
                    Console.WriteLine(train);
                }


            }
            else if (dayORnight == "night")
            {
                if (n >= 0 && n < 20)
                {
                    taxi = 0.70 + (0.90 * n);
                    Console.WriteLine(taxi);
                }
                else if (n >= 20 && n < 100)
                {
                    bus = 0.09 * n;
                    Console.WriteLine(bus);
                }
                else if (n >= 100)
                {
                    train = 0.06 * n;
                    Console.WriteLine(train);
                }
            }
        }
    }
}
