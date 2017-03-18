using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SmplCa_ConverterFromRadianToDagree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Formula ot Radian kum Degree: Radian * (180 / Math.PI)
            //Formula ot Degree kum Radian: (Math.PI / 180)
            double Radian = double.Parse(Console.ReadLine());
            double Degree = Radian * (180 / Math.PI);
            Console.WriteLine("{0}", (Math.Round(Degree)));
        }
    }
}
