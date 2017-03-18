using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DogHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            double wight = double.Parse(Console.ReadLine());
            double haight = double.Parse(Console.ReadLine());

            double twoWalls = wight * (wight / 2) * 2;
            double backWall = (wight / 2) * (wight / 2) + ((wight / 2) * (haight - wight / 2)) / 2;
            double entrance = (wight / 5) * (wight / 5);

            double frontWall = backWall - entrance;
            double AllGreenColor = (twoWalls + backWall + frontWall)/3;

            double cealing = wight * (wight / 2) * 2;
            double REDcolor = cealing / 5;

            Console.WriteLine("{0:f2}",AllGreenColor);
            Console.WriteLine("{0:f2}",REDcolor);


        }
    }
}
