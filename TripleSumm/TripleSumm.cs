using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSumm
{
    class TripleSumm
    {
        static void Main(string[] args)
        {
            //Write a program to read an array of integers and find all triples of elements a, b and c, such that a + b == c (where a
            //stays left from b). Print “No” if no such triples exist.

            //Input:1 1 1 1   =>  Output:No
            //Input:4 2 8 6  =>  Output:4 + 2 == 6
            //                          2 + 6 == 8
           

            //Input
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //Simple logic
            bool isFound = false;
            for (int first = 0; first < numbers.Length-1; first++)
            {
                for (int second = first+1; second < numbers.Length; second++)
                {
                    int result = numbers[first] + numbers[second];
                    if (numbers.Contains(result))
                    {
                        Console.WriteLine($"{numbers[first]} + {numbers[second]} == {result}");
                        isFound=true;
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
