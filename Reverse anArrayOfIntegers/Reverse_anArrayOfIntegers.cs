using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_anArrayOfIntegers
{
    class Reverse_anArrayOfIntegers
    {
        static void Main(string[] args)
        {
            //Write a program to read an array of integers, reverse it and print its elements. The input consists of a number n
            //(the number of elements) +n integers, each as a separate line. Print the output on a single line(space separated).
            //Input:3     => Output: 30 20 10
                  //10
                  //20
                  //30
          
            //FIRST SOLUTION 
            //Input
            //int numbers = int.Parse(Console.ReadLine());
            //int[] result = new int[numbers];

            //Simple logic
            //for (int i = 0; i < numbers; i++)
            //{
            //    result[i] = int.Parse(Console.ReadLine()); 
            //}

            //result = result.Reverse().ToArray();

            //Output
            //Console.WriteLine(string.Join(" ",result));

            //----------------------------------------------------------------------------------------------


            //SECOND SOLUTION 
            // Input
            int numbers = int.Parse(Console.ReadLine());
            int[] result = new int[numbers];

           // Simple logic
             for (int i = 0; i < numbers; i++)
            {
                result[i] = int.Parse(Console.ReadLine());
            }

            for (int i = result.Length - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
                if (i >= 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.WriteLine();
                }
            }


        }
    }
}
