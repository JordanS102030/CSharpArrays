using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            //Compare two char arrays lexicographically(letter by letter).
            //Print the them in alphabetical order, each on separate line.
            //Input: a d c     => Output:abc
            //       d e f               def
            //Input: a n n i e     => Output:an
            //       a n                     annie

            //Input
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int min = Math.Min(firstArray.Length, secondArray.Length);
            int couter = 0;
            for (int i = 0; i < min; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    continue;
                }
                else if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine(firstArray);
                    Console.WriteLine(secondArray);
                }
                else
                {
                    Console.WriteLine(secondArray);
                    Console.WriteLine(firstArray);
                }
                couter++;
                break;
            }

            if (couter == 0)
            {
                if (firstArray.Length <= secondArray.Length)
                {
                    Console.WriteLine(firstArray);
                    Console.WriteLine(secondArray);
                }
                else
                {
                    Console.WriteLine(secondArray);
                    Console.WriteLine(firstArray);
                }
            }
        }
    }
}
