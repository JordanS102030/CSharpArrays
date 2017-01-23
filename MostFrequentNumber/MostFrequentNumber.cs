using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            //Write a program that finds the most frequent number in a given sequence of numbers.

            //Input:4 1 1 4 2 3 4 4 1 2 4 9 3 => Output: 4

            //Input
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //Logic
            int couter = 0;
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int tempCounter = 0;
                //for (int j = 0; j < numbers.Length; j++)  
                //{
                //    if (numbers[i] == numbers[j])
                //    {
                //        tempCounter++;

                //    }
                //}
                foreach (var num in numbers)
                {
                    if (numbers[i] == num)
                    {
                        tempCounter++;
                    }
                }
                if (tempCounter > couter)
                {
                    couter = tempCounter;
                    result = numbers[i];
                }
            }
            //Output
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
