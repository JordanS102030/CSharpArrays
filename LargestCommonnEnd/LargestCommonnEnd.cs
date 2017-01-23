using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonnEnd
{
    class LargestCommonnEnd
    {
        static void Main(string[] args)
        {
            //Read two arrays of words and find the length of the largest common end (left or right).
            // Input:hi php java csharp sql html css js        => Output:3
            //       hi php java js softuni nakov java learn
            // Input:hi php java xml csharp sql html css js        => Output:4
            //       ivan java sql html css js
            //Input
            string[] firstArr = Console.ReadLine().Split(' ').ToArray();
            string[] secondArr = Console.ReadLine().Split(' ').ToArray();

            //Logic
            int min = Math.Min(firstArr.Length, secondArr.Length);
            int leftCounter = 0;
            int rightCounter = 0;
            for (int i = 0; i < min; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    leftCounter++;
                }
            }

            for (int i = 0; i < min; i++)
            {
                if(firstArr[firstArr.Length - 1 - i] == secondArr[secondArr.Length - 1 - i])
                {
                    rightCounter++;
                }
            }
            Console.WriteLine(Math.Max(rightCounter,leftCounter));
        }
    }
}
