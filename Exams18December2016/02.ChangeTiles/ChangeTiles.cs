using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeTiles
{
    class ChangeTiles
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double weightFloor = double.Parse(Console.ReadLine());
            double haightFloor = double.Parse(Console.ReadLine());
            double triangleSize = double.Parse(Console.ReadLine());
            double triangleHight = double.Parse(Console.ReadLine());
            double priseOfBrick = double.Parse(Console.ReadLine());
            double bauMaster = double.Parse(Console.ReadLine());


            var sizeOfTheFloor = weightFloor * haightFloor;
            var sizeOfBrick = triangleSize*triangleHight/2;
            var briksNeeded = Math.Ceiling((sizeOfTheFloor / sizeOfBrick));
            briksNeeded += 5;
            var MoneyNeeded = briksNeeded * priseOfBrick + bauMaster;
            if (MoneyNeeded<=money)
            {
                Console.WriteLine("{0:f2} lv left.",(money- MoneyNeeded ));
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.",(MoneyNeeded- money ));
            }
        }
    }
}
