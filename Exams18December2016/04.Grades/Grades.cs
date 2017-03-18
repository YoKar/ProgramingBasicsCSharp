using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            int NumbersOfStudents = int.Parse(Console.ReadLine());
            var topStudent = 0.0;
            var SBetwiine4and499 = 0.00;
            var thresStudents = 0.00;
            var fails = 0.00;
            var avarage = 0.00;
            var average = 0.0;

            for (int i = 0; i < NumbersOfStudents; i++)
            {
                double grades = double.Parse(Console.ReadLine());
                average += grades;
                if (grades>=5)
                {
                    topStudent++;
                }
                else if (grades>=4&&grades<5)
                {
                    SBetwiine4and499++;
                }
                else if (grades>=3&&grades<4)
                {
                    thresStudents++;
                }
                else if (grades<3)
                {
                    fails++;
                }
            }
            Console.WriteLine("Top students: {0:f2}%",(topStudent*100/NumbersOfStudents));
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%",(SBetwiine4and499*100/NumbersOfStudents));
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%",(thresStudents*100/NumbersOfStudents));
            Console.WriteLine("Fail: {0:f2}%",(fails*100/NumbersOfStudents));
            Console.WriteLine("Average: {0:f2}",average/NumbersOfStudents);

        }
    }
}
