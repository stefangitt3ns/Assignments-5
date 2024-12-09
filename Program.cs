using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 121;
            char lastCharacter = '0';

            if (x < 1)
            {
                Console.WriteLine("This number is not palandromic");
                return;
            }
            else if (x > 1)
            {
                string integerString = x.ToString();
                if (integerString[integerString.Length - 1] == lastCharacter)
                {
                    Console.WriteLine("This number is not palindromic");
                    return;
                }
            }
            else
            {
                int num = x, rev, sum = 0,
                temp = x;

                while (num > 0)
                {
                    rev = num % 10;           // Get the last digit
                    sum = (sum * 10) + rev;  // Build the reversed number
                    num = num / 10;          // Remove the last digit
                }

                // Check if the reversed number matches the original
                if (temp == sum)
                    Console.WriteLine("Yay! The given number is a Palindrome.");
                else
                    Console.WriteLine("Oops! The given number is not a Palindrome.");

            }
        }


    
            // Assignment 5.1.2
            static int SumOfDigits(int number)
            {
                int sum = 0;

                // Make sure the number is positive
                number = Math.Abs(number);

                while (number > 0)
                {
                    sum += number % 10; // Extract the last digit and add it to the sum
                    number /= 10;       // Remove the last digit
                }

                return sum;
            }


            int[] newArray = { 1, 2, 3, 1 };

            // Assignment 5.1.3  -  A method using HashSets to find Duplicates

            public static bool Duplicates(int[] array)
            {
                HashSet<int> seen = new HashSet<int>();  // a hashset to store the unique values

                foreach (int num in array)
                {
                    if (seen.Contains(num)) ; // checking if number is already in the HashSet
                    {
                        return true;
                    }
                    seen.Add(num);  // adds the unique element to the HashSet    

                }
                return false; // no duplicates

            }





        

    }
}
