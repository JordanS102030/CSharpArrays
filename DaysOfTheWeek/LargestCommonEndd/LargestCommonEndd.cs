using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEndd
{
    class LargestCommonEndd
    {
        static void Main(string[] args)
        {
            //Input
            string[] arr1 = Console.ReadLine().Split(' ').ToArray();
            string[] arr2 = Console.ReadLine().Split(' ').ToArray();

            //Logic
            int max = Math.Max(arr1.Length, arr2.Length);
            int leftCouter = 0;
            for (int i = 0; i < max; i++)
            {
                if (arr1.Length == arr2.Length)
                {
                    leftCouter++;
                }

            }
        }
    }
}
