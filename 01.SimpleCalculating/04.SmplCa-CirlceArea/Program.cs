using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmplCa__CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Radiusyt se zadava ot usera 
            double r = double.Parse(Console.ReadLine());
            //Formula za lice na krug: PI*r*r . PI moje da bude izveden ot komandata 'Math.PI'
            double Area = (Math.PI * r * r);
            //Formulata za perimeter na krug : 2 * PI * r.
            double Perimeter = (2 * Math.PI * r);
            Console.WriteLine("Area = "+Area);
            Console.WriteLine("Perimeter = "+Perimeter);

        }
    }
}
