using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.SimplCond_AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();
            if (figure=="square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(a*a);
            }
            else if (figure=="rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(a*b);
            }
            else if (figure=="circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.PI*r*r);
            }
            else if (figure=="triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine(a*h/2);
            }
        }
    }
}
