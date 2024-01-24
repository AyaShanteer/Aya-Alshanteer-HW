using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Q3) Write C# program to check if an input number is a prime number. Hints: 

A prime is a natural number greater than 1 that has no positive divisors other than 1 and itself. 
Example 1 (Test case 1): Input : n = 5 Output : 5 is prime 
Example 2 (Test case 2): Input : n = 10 Output : 10 is NOT prime*/


namespace AYAHW1Q3
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is prime
            bool isPrime = IsPrime(number);

            // Display the result
            if (isPrime)
            {
                Console.WriteLine($"{number} is prime.");
            }
            else
            {
                Console.WriteLine($"{number} is NOT prime.");
            }

            // Keep the console window open until a key is pressed
            Console.ReadKey();
        }

        static bool IsPrime(int n)
        {
            // 0 and 1 are not prime numbers
            if (n <= 1)
            {
                return false;
            }

            // Check for divisors from 2 to the square root of n
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    // Found a divisor, not a prime number
                    return false;
                }
            }

            // No divisors found, it's a prime number
            return true;
        }
    }

}
