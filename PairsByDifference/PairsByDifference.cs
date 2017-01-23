using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            //Write a program that count the number of pairs in given array which difference is equal to given number.

            //Input:1 5 3 4 2 => Output:3
            //      2

            //Input
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());
            //Logic
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int result = Math.Abs(nums[i] - nums[j]);
                    if (result == diff)
                    {
                        count = count + 1;
                    }
                }
            }
            //Output
            Console.WriteLine(count);

        }
    }
}
