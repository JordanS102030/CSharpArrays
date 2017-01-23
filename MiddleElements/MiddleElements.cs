using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleElements
{
    class MiddleElements
    {
        static void Main(string[] args)
        {
            //Write a method to extract the middle 1, 2 or 3 elements from array of n integers and print them.
            // n = 1; 1 element
            // even n=  2 elements
            // odd n = 3 elements
            //Create a program that reads an array of integers (space separated values) and prints the middle elements in the
            //format shown in the examples.

            //Input:5 => Output:{ 5 } 
            //Input:10 20 30 40 50 60 70 80 => Output:{ 40, 50 } 
            //Input
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //Simple logic

            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);

            }
            else if (numbers.Length % 2 == 0)
            {
                Console.WriteLine($"{numbers[numbers.Length / 2 - 1]}, {numbers[numbers.Length / 2]}");

            }
            else
            {
                Console.WriteLine($"{numbers[numbers.Length / 2 - 1]}, {numbers[numbers.Length / 2]}, {numbers[numbers.Length / 2 + 1]}");
            }

        }
    }
}
