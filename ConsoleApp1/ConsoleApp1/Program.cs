using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double cogs = 79.99;
            const double gears = 250;
            int cogscount = 0;
            int gearscount = 0;
            const double markup = .15;
            const double discountmarkup = .125;
            double salestax = .089;
            double markupChoice;

            Console.Write("Please enter the number of cogs purchase:");
            cogscount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the number of gears purchase:");
            gearscount = Convert.ToInt32(Console.ReadLine());

            int totalcount = cogscount + gearscount;
            if (totalcount >= 16)
            {
                markupChoice = discountmarkup;
            }
           else if (cogscount>= 10)
            {
                markupChoice = discountmarkup;
            }
           else if (gearscount >= 10)
            {
                markupChoice = discountmarkup;
            }
            else
            {
                markupChoice = markup;
            }
            double cogsTotal = cogscount * cogs;
            double gearsTotal = gearscount * gears;
            double Subtotal = gearsTotal + cogsTotal;
            double mTotal = (Subtotal * markupChoice);
            double SalesTaxT = Subtotal * salestax;
            double grandTotal = SalesTaxT + mTotal + Subtotal;

            Console.WriteLine($"The total cost for the items is {Subtotal}, the markup amount is {mTotal}, the sales tax is {SalesTaxT}, and the grand total is {grandTotal}");
            Console.Read();



        }
    }
}
