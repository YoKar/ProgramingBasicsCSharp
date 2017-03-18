using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.SimplCond_NumbersFrom0To100Words
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string intNumWord = "";
            string numWord = "";
            string teenNumWord = "";
            if (num<=10&&num>0)
            {
                switch (num)
                {
                    case 1:numWord = "one";
                        break;
                    case 2:
                        numWord = "two";
                        break;
                    case 3:
                        numWord = "three";
                        break;
                    case 4:
                        numWord = "four";
                        break;
                    case 5:
                        numWord = "five";
                        break;
                    case 6:
                        numWord = "six";
                        break;
                    case 7:
                        numWord = "seven";
                        break;
                    case 8:
                        numWord = "eight";
                        break;
                    case 9:
                        numWord = "nine";
                        break;
                    case 10:
                        numWord = "ten";
                        break;
                }
                Console.WriteLine(numWord);
            }
            else if (num >10&&num<20)
            {
                switch (num)
                {
                    case 11: teenNumWord = "eleven";
                        break;
                    case 12:
                        teenNumWord = "twelve";
                        break;
                    case 13:
                        teenNumWord = "thirteen";
                        break;
                    case 14:
                        teenNumWord = "fourteen";
                        break;
                    case 15:
                        teenNumWord = "fifteen";
                        break;
                    case 16:
                        teenNumWord = "sixteen";
                        break;
                    case 17:
                        teenNumWord = "seventeen";
                        break;
                    case 18:
                        teenNumWord = "eighteen";
                        break;
                    case 19:
                        teenNumWord = "nineteen";
                        break;
                }
                Console.WriteLine(teenNumWord);
            }
            else if (num!=0&&num>=20&&num<100)
            {
                switch (num/10)
                {
                    case 2:intNumWord = "twenty";
                        break;
                    case 3:
                        intNumWord = "thirty";
                        break;
                    case 4:
                        intNumWord = "fourty";
                        break;
                    case 5:
                        intNumWord = "fifty";
                        break;
                    case 6:
                        intNumWord = "sixty";
                        break;
                    case 7:
                        intNumWord = "seventy";
                        break;
                    case 8:
                        intNumWord = "eighty";
                        break;
                    case 9:
                        intNumWord = "ninety";
                        break;
                }
                switch (num%10)
                {
                    case 1:
                        numWord = " one";
                        break;
                    case 2:
                        numWord = " two";
                        break;
                    case 3:
                        numWord = " three";
                        break;
                    case 4:
                        numWord = " four";
                        break;
                    case 5:
                        numWord = " five";
                        break;
                    case 6:
                        numWord = " six";
                        break;
                    case 7:
                        numWord = " seven";
                        break;
                    case 8:
                        numWord = " eight";
                        break;
                    case 9:
                        numWord = " nine";
                        break;
                }
                Console.WriteLine("{0}{1}",intNumWord ,numWord);
            }
            if (num==100)
            {
                Console.WriteLine("one hundred");
            }
            else if (num==0)
            {
                Console.WriteLine("zero");
            }
            else if ((num<0||num>100))
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
