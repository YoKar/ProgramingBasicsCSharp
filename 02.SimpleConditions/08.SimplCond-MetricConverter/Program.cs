using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SimplCond_MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string FirstUnit = Console.ReadLine().ToLower();
            string SecondUnit = Console.ReadLine().ToLower();
            double FirstValue = 0.0;
            double SecondValue = 0.0;
            if (FirstUnit=="mm")
            {
                FirstValue = num / 1000;
            }
            else if (FirstUnit=="m")
            {
                FirstValue = num ;
            }
            else if (FirstUnit=="cm")
            {
                FirstValue = num / 100;
            }
            else if (FirstUnit=="mi")
            {
                FirstValue = num / 0.000621371192; 
            }
            else if (FirstUnit=="in")
            {
                FirstValue = num / 39.3700787;
            }
            else if (FirstUnit=="km")
            {
                FirstValue = num / 0.001;
            }
            else if (FirstUnit=="ft")
            {
                FirstValue = num / 3.2808399;
            }
            else if (FirstUnit=="yd")
            {
                FirstValue = num / 1.0936133;
            }
            if (SecondUnit=="mm")
            {
                SecondValue = FirstValue * 1000;
            }
            else if (SecondUnit=="m")
            {
                SecondValue = FirstValue * 1;
            }
            else if (SecondUnit=="cm")
            {
                SecondValue = FirstValue * 100;
            }
            else if (SecondUnit=="mi")
            {
                SecondValue = FirstValue * 0.000621371192;
            }
            else if (SecondUnit=="in")
            {
                SecondValue = FirstValue * 39.3700787;
            }
            else if (SecondUnit=="km")
            {
                SecondValue = FirstValue * 0.001;
            }
            else if (SecondUnit=="ft")
            {
                SecondValue = FirstValue * 3.2808399;
            }
            else if (SecondUnit=="yd")
            {
                SecondValue = FirstValue * 1.0936133;
            }
            Console.WriteLine("{0}",SecondValue);
        }
    }
}
