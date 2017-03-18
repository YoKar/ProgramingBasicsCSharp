using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            double firstSpeed = double.Parse(Console.ReadLine());
            double timeFirst = double.Parse(Console.ReadLine());
            double timeSecond = double.Parse(Console.ReadLine());
            double timeThird = double.Parse(Console.ReadLine());

            var firstRange = firstSpeed * (timeFirst / 60);
            var secondRange = firstSpeed + (firstSpeed * 0.1);
            firstSpeed = firstSpeed + (firstSpeed * 0.1);
            secondRange = secondRange * (timeSecond / 60);
            firstSpeed = firstSpeed - (firstSpeed * 0.05);
            var thirdRange = firstSpeed * (timeThird / 60);
            
            Console.WriteLine("{0:f2}",(firstRange+secondRange+thirdRange));
        }
    }
}
