using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //The first method that you will need to create is to calculate the y value of a line, given by the slope(m), the x value (x) and the y intercept (b). 
            //Your method should be named LineValueForY with a return type of double.  Y.  Your method should accept 3 parameters, all of type double.  
            //The first parameter will be the slope of the line (name this parameter m), the second parameter should be the x value (name this parameter x) 
            //and the last parameter should be the y intercept (name this parameter b).  The formula to calculate the Y value is Y = mx + b
            double LineValueForY = 0;
            double m;
            double x;
            double b;
            Console.WriteLine("Please enter the slope or m:");
            m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the x value:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the y intercept or b:");
            b = Convert.ToDouble(Console.ReadLine());
            LineValueForY = (m * x) + b;
            Console.WriteLine($"Your solution is {LineValueForY}");
            Console.Read();


        }
    }
}
