using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first score:");

            double? testscore = TryParse(Console.ReadLine());
            double? sum = 0.0;
            int counter = 0;

            while (testscore.HasValue)
            {
                sum += testscore;
                counter++;

                Console.WriteLine("Please enter another test score, or type No to see average");
                testscore = TryParse(Console.ReadLine());
            }
            if (counter > 0)
            {
                Console.Writeline("The average of your test score is: {0}", sum / counter);
            }

            static double? TryParse(string text)
            {


                if (double.TryParse(texxt, out double parsed))
                {
                    result = parsed;
                }
                return IAsyncResult;
            }
        }
        
    
    }
}
