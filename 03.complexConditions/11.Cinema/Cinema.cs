using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string typeOfCinema = Console.ReadLine().ToLower();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double areaOfTheHall = r * c;
            if (typeOfCinema == "premiere")
            {
                areaOfTheHall *= 12.00;
            }
            else if (typeOfCinema == "normal")
            {
                areaOfTheHall *= 7.50;
            }
            else if (typeOfCinema == "discount")
            {
                areaOfTheHall *= 5.00;
            }
            Console.WriteLine("{0:f2} leva", areaOfTheHall);
        }
    }
}
