using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a console application that prompts the user to create a list of exam grades and then calculates the average. Your application should include two loops:
            //Loop #1 should initialize the entry of all quiz grades.
            //Loop #2 should calculate the sum and average of the total quiz grades.
            string answer;
            int sum = 0;
            double average = 0;

            List<int> Grades = new List<int>();
            Console.WriteLine("Please enter your quiz scores or stop to finish:");
            answer = Convert.ToString(Console.ReadLine());
            while (!answer.Equals("stop"))
            {

                Grades.Add(Convert.ToInt32(answer));
                answer = Convert.ToString(Console.ReadLine());
            }
            for (int i = 0; i < Grades.Count; i++)
            {
                sum = Grades.Sum();
                average = Grades.Average();
            }
            double uAverage = average / 100;
            Console.WriteLine($"The sum of your quiz grades is: {sum}");
            Console.WriteLine($"The average of your quiz grades is: {average:P}");
            Console.ReadKey();
            
               
            
        }
    }
}
