using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayyModifier
{
    class ArrayyModifier
    {
        static void Main(string[] args)
        {
            // You are given an array with integers.Write a program to modify the array elements after processing a sequence of commands “swap”, “multiply” or “decrease”. The commands are as follows:
            //“swap { index1}{ index2}” takes two elements and swaps them.
            //“multiply { index1} { index2}” takes element at the 1st index and multiplies it with the element at 2nd index. Save the product at the 1st index.
            //“decrease” decreases all elements in the array with 1.


            //Input
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            //Logic

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                if (command[0] == "end")
                {
                    break;
                }
                if (command[0] == "swap")
                {
                    Swap(numbers, command);
                }
                else if (command[0] == "multiply")
                {
                    Multiply(numbers, command);
                }
                else if(command[0] == "decrease")
                {
                    decrease(numbers);
                }
            }
            //Output
            Console.WriteLine(string.Join(", ",numbers));

        }

        private static void decrease(long[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i]--;
            }
        }

        private static void Multiply(long[] numbers, string[] command)
        {
            int index1 = int.Parse(command[1]);
            int index2 = int.Parse(command[2]);
            numbers[index1] *= numbers[index2];
        }

        private static void Swap(long[] numbers, string[] command)
        {
            int index1 = int.Parse(command[1]);
            int index2 = int.Parse(command[2]);
            long old = numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = old;
        }
    }
}
