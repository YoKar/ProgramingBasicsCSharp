using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TradeComission
{
    class TradeComission
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double trades = double.Parse(Console.ReadLine());
            double comission = 0.0;
            if (trades < 0)
            {
                Console.WriteLine("error");
            }
            else if (city == "sofia")
            {
                if (trades >= 0 && trades <= 500)
                {
                    comission = trades * 0.05;
                }
                else if (trades > 500 && trades <= 1000)
                {
                    comission = trades * 0.07;
                }
                else if (trades > 1000 && trades <= 10000)
                {
                    comission = trades * 0.08;
                }
                else if (trades > 10000)
                {
                    comission = trades * 0.12;
                }
                Console.WriteLine("{0:f2}", comission);
            }
            else if (city == "varna")
            {
                if (trades >= 0 && trades <= 500)
                {
                    comission = trades * 0.045;
                }
                else if (trades > 500 && trades <= 1000)
                {
                    comission = trades * 0.075;
                }
                else if (trades > 1000 && trades <= 10000)
                {
                    comission = trades * 0.10;
                }
                else if (trades > 10000)
                {
                    comission = trades * 0.13;
                }
                Console.WriteLine("{0:f2}", comission);
            }
            else if (city == "plovdiv")
            {
                if (trades >= 0 && trades <= 500)
                {
                    comission = trades * 0.055;
                }
                else if (trades > 500 && trades <= 1000)
                {
                    comission = trades * 0.08;
                }
                else if (trades > 1000 && trades <= 10000)
                {
                    comission = trades * 0.12;
                }
                else if (trades > 10000)
                {
                    comission = trades * 0.145;
                }
                Console.WriteLine("{0:f2}", comission);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
