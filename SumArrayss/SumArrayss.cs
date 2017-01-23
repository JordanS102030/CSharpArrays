using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrayss
{
    class SumArrayss
    {
        static void Main(string[] args)
        {
            // Write a program that reads two arrays of integers and sums them. When the arrays are not of the same size,
            // duplicate the smaller array a few times.

            //Input:1 2 3 4   => Output: 3 5 7 9
            //      2 3 4 5 
            //Input:1 2 3 4 5   => Output: 3 5 5 7 7
            //      2 3 

            //Input
            int[] numbers1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] numbers2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //Simple logic
            int max = Math.Max(numbers1.Length, numbers2.Length);
            int[] result = new int[max];
            for (int i = 0; i < max; i++)
            {
                result[i] = numbers1[i % numbers1.Length] + numbers2[i % numbers2.Length];
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
