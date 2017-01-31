using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SmplCa_TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Formula za lice na triugulnik: a * h / 2
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double Area = a * h / 2;
            //Izpolzvame Math.Round ('drobnoto chislo'(Area) , 'do kolko chisla sled desetichnata zapetaq'(2))
            //Drug variant e s PlaceHolder "{0:f2}",Area
            Console.WriteLine("Triangle area = "+(Math.Round(Area,2)));
        }
    }
}
