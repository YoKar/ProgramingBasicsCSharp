using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmplCa_TrapezeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dve strani s visochina 
            int b1 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            //Formula : (b1+b2)*h/2 (ima delene vuv formulata , izpolzvame tip za drobno chislo!!! Double or Decimal
            double Area = (double)(b1 + b2) * h / 2;
            //Double v skobite convertira formulata da dava drobno chislo
            Console.WriteLine("Trapezoid Area ="+Area );
        }
    }
}
