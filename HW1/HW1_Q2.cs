using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Q2) Write C# program that calculate Fibonacci Sequence. 

Hints: In mathematical terms, the sequence Fn of Fibonacci numbers is defined by the recurrence relation Fn = Fn-1 + Fn-2 The Fibonacci numbers are the numbers in the following integer sequence.

 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ……..
Example 1 (Test case 1): Input : n = 9 Output : 34 
Example 2 (Test case 2): Input : n = 6 Output : 8*/

namespace AYA202111261HW1Q2
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Display the nth Fibonacci number
            int result = Fibonacci(n);
            Console.WriteLine($"Fibonacci({n}) = {result}");

            // Keep the console window open until a key is pressed
            Console.ReadKey();
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }

}
