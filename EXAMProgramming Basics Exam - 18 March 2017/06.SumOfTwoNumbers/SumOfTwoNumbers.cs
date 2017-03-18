using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumOfTwoNumbers
{
    class SumOfTwoNumbers
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int megicNum = int.Parse(Console.ReadLine());
            bool breaker = false;
            var counter = 0;
            var Sum = 0;
            var f = 0;
            var s = 0;
            for (int i = firstNum; i <= secondNum; i++)
            {
                
                if (breaker)
                {
                    break;
                }
                for (int j = firstNum; j <= secondNum; j++)
                {
                    counter++;
                    if (i+j==megicNum)
                    {
                        f = i;
                        s = j;
                        Sum = i + j;
                        breaker = true;
                        break;
                    }
                }
            }
            if (breaker)
            {
                Console.Write("Combination N:{0} ",counter);
                Console.WriteLine("({0} + {1} = {2})",f,s,megicNum);
            }
            else
            {
                Console.WriteLine("{0} combinations - neither equals {1}",counter,megicNum);
            }
        }
    }
}
