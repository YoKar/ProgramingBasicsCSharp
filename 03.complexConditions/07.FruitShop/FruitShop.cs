using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana")
                {
                    quantity *= 2.50;
                    Console.WriteLine("{0:f2}", quantity);
                }
                else if (fruit == "apple")
                {
                    quantity *= 1.20;
                    Console.WriteLine("{0:f2}", quantity);
                }
                else if (fruit == "orange")
                {
                    quantity *= 0.85;
                    Console.WriteLine("{0:f2}", quantity);
                }
                else if (fruit == "grapefruit")
                {
                    quantity *= 1.45;
                    Console.WriteLine("{0:f2}", quantity);
                }
                else if (fruit == "kiwi")
                {
                    quantity *= 2.70;
                    Console.WriteLine("{0:f2}", quantity);
                }
                else if (fruit == "pineapple")
                {
                    quantity *= 5.50;
                    Console.WriteLine("{0:f2}", quantity);
                }
                else if (fruit == "grapes")
                {
                    quantity *= 3.85;
                    Console.WriteLine("{0:f2}", quantity);
                }

                else
                {
                    Console.WriteLine("error");
                }

            }
            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana")
                {
                    quantity *= 2.70;
                    Console.WriteLine("{0:f2}", quantity);
                }
                else if (fruit == "apple")
                {
                    quantity *= 1.25;
                    Console.WriteLine("{0:f2}", quantity);
                }
                else if (fruit == "orange")
                {
                    quantity *= 0.90;
                    Console.WriteLine("{0:f2}", quantity);
                }
                else if (fruit == "grapefruit")
                {
                    quantity *= 1.60;
                    Console.WriteLine("{0:f2}", quantity);
                }
                else if (fruit == "kiwi")
                {
                    quantity *= 3.00;
                    Console.WriteLine("{0:f2}", quantity);
                }
                else if (fruit == "pineapple")
                {
                    quantity *= 5.60;
                    Console.WriteLine("{0:f2}", quantity);
                }
                else if (fruit == "grapes")
                {
                    quantity *= 4.20;
                    Console.WriteLine("{0:f2}", quantity);
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
