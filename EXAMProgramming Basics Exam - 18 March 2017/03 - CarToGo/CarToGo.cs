
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___CarToGo
{
    class CarToGo
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string seasone = Console.ReadLine();
            string Clases = string.Empty;
            double cabrio = 0.0;
            double jeep = 0.0;
            if (budjet<=100)
            {
                Clases = "Economy class";
                if (seasone=="Summer")
                {
                    cabrio = budjet * 0.35;
                    Console.WriteLine("{0}",Clases);
                    Console.WriteLine("Cabrio - {0:f2}",cabrio);
                }
                else 
                {
                    jeep = budjet * 0.65;
                    Console.WriteLine("{0}",Clases);
                    Console.WriteLine("Jeep - {0:f2}",jeep);
                }
            }
            else if (budjet>100&&budjet<=500)
            {
                Clases = "Compact class";
                if (seasone == "Summer")
                {
                    cabrio = budjet * 0.45;
                    Console.WriteLine("{0}", Clases);
                    Console.WriteLine("Cabrio - {0:f2}", cabrio);
                }
                else
                {
                    jeep = budjet * 0.80;
                    Console.WriteLine("{0}", Clases);
                    Console.WriteLine("Jeep - {0:f2}", jeep);
                }
            }
            else if (budjet>500)
            {
                Clases = "Luxury class";
                jeep = budjet * 0.9;
                Console.WriteLine("{0}", Clases);
                Console.WriteLine("Jeep - {0:f2}", jeep);
            }
           
        }
    }
}
