using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_1
{
    class Program
    {
        static void Main(string[] args)
        {
 

            String[] ItemName = { "Apples", "Oranges", "Bananas", "Grapes", "Blueberries" };
            double[] ItemPrice = { 0.99, 0.50, 0.50, 2.99, 1.99 };
            string Inputchoice;
            double price;
            Console.Write("Please enter your desired items :");
            Inputchoice = Console.ReadLine();
            int index;
            for (index= 0; index <= ItemName.Length; index++)
            {
                if (Inputchoice.ToUpper() == ItemName[index].ToUpper())
                {
                    price = ItemPrice[index];
                    Console.Write($"The Price for {Inputchoice} is {price}");
                    break;

                }
                else
                {
                    Console.WriteLine("Invalid input");
                    break;
                }
            }
            
            Console.ReadLine();

        }
    }
}
