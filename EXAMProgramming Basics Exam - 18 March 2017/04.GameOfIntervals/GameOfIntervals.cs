using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GameOfIntervals
{
    class GameOfIntervals
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double points = 0.0;
            double from0to9 = 0;
            double from10to19 = 0;
            double from20to29 = 0;
            double from30to39 = 0;
            double from40to50 = 0;
            double invalideNumber = 0;
            for (int i = 0; i < num; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number>=0&&number<=9)
                {
                    from0to9++;
                    points += number * 0.2;
                }
                else if (number>=10&&number<=19)
                {
                    from10to19++;
                    points += number * 0.3;
                }
                else if (number>=20&&number<=29)
                {
                    from20to29++;
                    points += number * 0.4;
                }
                else if (number>=30&&number<=39)
                {
                    from30to39++;
                    points += 50;
                }
                else if (number>=40&&number<=50)
                {
                    points += 100;
                    from40to50++;
                }
                else if (number<0||number>50)
                {
                    invalideNumber++;
                    points /= 2;
                }
            }
            Console.WriteLine("{0:f2}",points);
            Console.WriteLine("From 0 to 9: {0:f2}%",(from0to9*100)/num);
            Console.WriteLine("From 10 to 19: {0:f2}%", (from10to19*100)/ num);
            Console.WriteLine("From 20 to 29: {0:f2}%", (from20to29*100)/ num);
            Console.WriteLine("From 30 to 39: {0:f2}%", (from30to39*100)/ num);
            Console.WriteLine("From 40 to 50: {0:f2}%", (from40to50 * 100)/ num);
            Console.WriteLine("Invalid numbers: {0:f2}%",(invalideNumber*100)/num);
        }
    }
}
