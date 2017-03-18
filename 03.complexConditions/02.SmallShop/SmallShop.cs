using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double prise = 0;

            if (city == "Sofia")
            {
                if (product=="coffee")
                {
                    prise = 0.50;
                }
                else if (product=="water")
                {
                    prise = 0.80;
                }
                else if (product=="beer")
                {
                    prise = 1.20;
                }
                else if (product=="sweets")
                {
                    prise = 1.45;
                }
                else if (product=="peanuts")
                {
                    prise = 1.60;
                }
            }
            else if (city=="Plovdiv")
            {
                if (product == "coffee")
                {
                    prise = 0.40;
                }
                else if (product == "water")
                {
                    prise = 0.70;
                }
                else if (product == "beer")
                {
                    prise = 1.15;
                }
                else if (product == "sweets")
                {
                    prise = 1.30;
                }
                else if (product == "peanuts")
                {
                    prise = 1.50;
                }
            }
            else if (city=="Varna")
            {
                if (product == "coffee")
                {
                    prise = 0.45;
                }
                else if (product == "water")
                {
                    prise = 0.70;
                }
                else if (product == "beer")
                {
                    prise = 1.10;
                }
                else if (product == "sweets")
                {
                    prise = 1.35;
                }
                else if (product == "peanuts")
                {
                    prise = 1.55;
                }
            }
            Console.WriteLine(quantity*prise);
        }
    }
}
