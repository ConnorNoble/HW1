using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //The second method that you will need to create is to calculate the factorial of a number.  Your method name should be Factorial and should have a return type of int. 
            //our method should accept a single parameter of type int.  To calculate the factorial of a number, you multiply it by every number before it.
            //e.g. 5 factorial = 5 * 4 * 3 * 2 * 1 = 120
            int i, num, factorial;
            Console.WriteLine("Please enter the number:");
            num = int.Parse(Console.ReadLine());
            factorial = num;
            for (i = num - 1; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("Factorial of given nuber is:" + factorial); 
            Console.ReadLine();
        }
    }
}
