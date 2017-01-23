using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateSum
{
    class RotateSum
    {
        static void Main(string[] args)
        {
            // To “rotate an array on the right” means to move its last element first: { 1, 2, 3}  { 3, 1, 2}.
            // Write a program to read an array of n integers (space separated on a single line) and an integer k, rotate the array
            // right k times and sum the obtained arrays after each rotation as shown below.

            //Input:3 2 4 -1 => Output => 3 2 5 6
            //      2
            //Input:1 2 3 => Output => 3 2 1
            //      1

            //Input
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());

            //Logic
            int [] result = new int[numbers.Length];
            for (int i = 0; i < rotation; i++)
            {
                int lastElement = numbers[numbers.Length - 1];
                for (int currentElement = numbers.Length-1; currentElement > 0 ; currentElement--)
                {
                    numbers[currentElement] = numbers[currentElement - 1];
                }
                numbers[0] = lastElement;
              
                for (int currentElement = 0; currentElement < numbers.Length; currentElement++)
                {
                    result[currentElement] += numbers[currentElement];
                }
            }

            //Output
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
