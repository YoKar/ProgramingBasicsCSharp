using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.SimplCaExams_SudyHall
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
          
                
                double table = Math.Floor((length*100) / 120);
                double chair = Math.Floor(((width-1)*100) / 70);
                int AllPlaces = (int)((table) * (chair));
                Console.WriteLine(AllPlaces - 3);
            
             }
    }
}
