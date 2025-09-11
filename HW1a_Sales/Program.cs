// HW1a Sales Total

// Your Name: Lucas Tenison
// Did you seek help ? If yes, specify the helper or web link here: My Dad

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare the tax rate constant
            const double Tax_Rate = 0.085;

            //Asking what item is being purchased
            Console.WriteLine("Enter the type of item you are purchasing:");
            //Define the item variable
            string Item = Console.ReadLine();

            //Ask for quantity
            Console.WriteLine("Enter the quantity of the item:");
            //Define the quantity variable
            int quantity = Convert.ToInt32(Console.ReadLine());


            //Ask for price
            Console.WriteLine("Enter the price of the item");
            //Define the price variable
            double price = Convert.ToDouble(Console.ReadLine());


            //Calculate the subtotal
            double subtotal = quantity * price;

            //Calculate sales tax
            double SalesTax = subtotal * Tax_Rate;

            //Calculate the total
            double total = subtotal + SalesTax;

            //The Outputs
            Console.WriteLine("Your subtotal is:$" + subtotal);
            Console.WriteLine("Your sales tax is:$" + SalesTax);
            Console.WriteLine("Your total is:$" + total);

            Console.ReadKey();
        }
    }
}
