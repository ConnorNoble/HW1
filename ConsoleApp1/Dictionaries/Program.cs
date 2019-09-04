using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> itemPrice = new Dictionary<string, double>(); 
            itemPrice.Add("Apples", 0.99);
            itemPrice.Add("Oranges",0.50 );
            itemPrice.Add("Bananas", 0.50 );
            itemPrice.Add("Grapes",2.99 );
            itemPrice.Add("Blueberries",1.99);
            string value;
            double price;

            Console.WriteLine("Here are our available produce \nApples \nOranges \nBananas \nGrapes \nBlueberries");
            Console.WriteLine("Select the item you would like");
            value = Console.ReadLine();
            for (int count = 0; count < itemPrice.Count; count++)
            {
                if(itemPrice.TryGetValue(value, out price))
                {
                    Console.WriteLine($"Price of {value:6} is {price:C}");
                }
            }
            Console.ReadKey();


            

        }


    }   }      
