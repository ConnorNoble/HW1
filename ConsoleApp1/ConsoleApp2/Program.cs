using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an application that will keep prompting the user to input all 3 of their exam grades (using a For loop).  
            //Calculate the average of their exam scores and output the result.  When you display the result, make sure to use a Format Specifier for percentages
            int i;
            int[] array = new int[3];
            for (i = 0; i < 3;i++)
            {
                Console.Write("Please enter your score:");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            double sum = 0;
            double average = 0;

            for (i = 0; i < 3; i++)
            {
                sum += array[i];
            }
            average = sum / 3;
            Console.WriteLine($"Your average grade is {average}");
            Console.ReadKey();


        }
    }
}
