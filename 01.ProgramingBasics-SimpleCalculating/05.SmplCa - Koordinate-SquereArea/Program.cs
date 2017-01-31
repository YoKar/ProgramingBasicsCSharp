using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._5.SmplCa___Koordinate_SquereArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Formula za lice na pravougulnik:A * B
            //Formula za Perimeter na pravougulnik;2 *(a+b)
            double y1 = double.Parse(Console.ReadLine());
            double x1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());

            double a = Math.Abs((y1) - (y2));
            double b = Math.Abs((x1) - (x2));
            double Area = a * b;
            double Perimeter = 2 * (a + b);
            Console.WriteLine(Area);
            Console.WriteLine(Perimeter);
        }
    }
}
