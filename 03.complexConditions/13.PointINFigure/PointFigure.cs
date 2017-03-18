using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.PointINFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int Fhx1 = 0;
            int Fhy1 = 0;
            int Fhx2 = h * 3;
            int Fhy2 = h * 1;
            int Shx1 = h * 1;
            int Shy1 = 0;
            int Shx2 = h * 2;
            int Shy2 = h * 4;
            if ((x > Fhx1 && x < Fhx2 && y > Fhy1 && y < Fhy2) || (x > Shx1 && x < Shx2 && y > Shy1 && y < Shy2))
            {
                Console.WriteLine("inside");
            }

            else if ((x == Fhx1 || x == Fhx2) && ((y > Fhy1 && y < Fhy2) || (y == Fhy1 || y == Fhy2)))
            {
                Console.WriteLine("border");
            }
            else if ((y == Fhy1 || y == Fhy2) && ((x > Fhx1 && x < Fhx2) || (x == Fhx1 || x == Fhx2)))
            {
                Console.WriteLine("border");
            }
            else if ((x == Shx1 || x == Shx2) && ((y > Shy1 && y < Shy2) || (y == Shy1 || y == Shy2)))
            {
                Console.WriteLine("border");
            }
            else if ((y == Shy1 || y == Shy2) && ((x > Shx1 && x < Shx2) || (x == Shx1 || x == Shx2)))
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
