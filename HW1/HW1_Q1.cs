using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Visual Programming Homework #1:
2023/2024 First Semester (Dr. Ala Abuthawabeh)

Q1) Write C# program that asks the buyer to enter the price of three items, calculates an applicable 10% 
discount on the items, and displays the net amount payable.*/

using System;

namespace AYASHANTEER202111261
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            Console.Write("Enter the price of item 1: ");
            double item1Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the price of item 2: ");
            double item2Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the price of item 3: ");
            double item3Price = Convert.ToDouble(Console.ReadLine());

            
            double totalPrice = item1Price + item2Price + item3Price;

           
            double discount = 0.1 * totalPrice;

           
            double netAmountPayable = totalPrice - discount;

            // Display the results
            Console.WriteLine($"Total Price: {totalPrice:C}");
            Console.WriteLine($"Discount (10%): {discount:C}");
            Console.WriteLine($"Net Amount Payable: {netAmountPayable:C}");

            
            Console.ReadKey();
        }
    }
}

