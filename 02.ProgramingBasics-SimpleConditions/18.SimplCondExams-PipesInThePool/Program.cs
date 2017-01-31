using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.SimplCondExams_PipesInThePool
{
    class Program
    {
        static void Main(string[] args)
        {
            int SizeInLIters = int.Parse(Console.ReadLine());
            int FirstPipeFlow = int.Parse(Console.ReadLine());
            int secondPipeFlow = int.Parse(Console.ReadLine());
            double hoursWorkerMissed = double.Parse(Console.ReadLine());
            double firstPipe = (FirstPipeFlow * hoursWorkerMissed);
            double secondPipe = (secondPipeFlow * hoursWorkerMissed);
            double AllLiters = firstPipe + secondPipe;
            double procentOfAllLiters = (AllLiters / SizeInLIters * 100);
            double procentOFfisrtPipe = (firstPipe / AllLiters * 100);
            double ProcentOfSecondPipe = (secondPipe / AllLiters * 100);
            if (AllLiters <= SizeInLIters)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", (int)procentOfAllLiters, (int)procentOFfisrtPipe, (int)ProcentOfSecondPipe);
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hoursWorkerMissed, ((firstPipe + secondPipe) - (SizeInLIters)));
            }
        }
    }
}
