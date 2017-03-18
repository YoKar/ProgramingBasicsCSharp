using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmplCa_FromInchesToSantimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izpolzvame 'Double' , zashtoto User-a maje da izpolzva drobni chisla
            double Inches = double.Parse(Console.ReadLine());
            Console.WriteLine("Inches = "+Inches);
            Console.WriteLine("Cantimeters = "+(Inches*2.54));
        }
    }
}
