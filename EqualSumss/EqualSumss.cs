using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumss
{
    class EqualSumss
    {
        static void Main(string[] args)
        {
            //Write a program that determines if there exists an element in the array such that the sum of the elements on its
            //left is equal to the sum of the elements on its right.If there are no elements to the left / right, their sum is
            //considered to be 0.Print the index that satisfies the required condition or “no” if there is no such index.

            //Input:1 2 3 3 => Output: 2 
            //Input:1 2  => Output: no
            //Input:1  => Output: 0


            //Input

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //Logic

            bool isFoundIndex = false;

            for (int currentElement = 0; currentElement < numbers.Length; currentElement++)
            {
                int sumRight = 0;
                int sumLeft = 0;

                for (int i = currentElement+1; i < numbers.Length; i++)
                {
                    sumRight += numbers[i];
                }
                for (int i = 0; i < currentElement; i++)
                {
                    sumLeft += numbers[i];
                   
                }
                if (sumLeft == sumRight)
                {
                    Console.WriteLine(currentElement);
                    isFoundIndex = true;
                }
            }

            if (!isFoundIndex)
            {
                Console.WriteLine("no");
            }
        }
    }
}
