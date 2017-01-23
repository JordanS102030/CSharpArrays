using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            // Write a program to read an array of real numbers (space separated values), round them to the nearest integer in
            // “away from 0” style and print the output as in the examples below.
            // Rounding in “away from zero” style means:
            // To round to the nearest integer, e.g. 2.9  3; -1.75  -2
            // In case the number is exactly in the middle of two integers(midpoint value), round it to the next integer
            // which is away from the 0:

            //Input:0.9 1.5 2.4 2.5 3.14 => Output:
            //                               0.9 => 1 
            //                               1.5 => 2
            //                               2.4 => 2
            //                               2.5 => 3
            //                               3.14 => 3
            

            //FIRST SOLUTION 
            //Input
            //double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            //Simple logic

            //foreach (var num in numbers)
            //{
            //    double rounded = Math.Round(num, MidpointRounding.AwayFromZero);
            //    Console.WriteLine("{0} => {1}",num,rounded);
            //}


            //-----------------------------------------------------------------------------------------------------

            //SECOND SOLUTION 
            //Input
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            //Simple logic

            for (int i = 0; i < numbers.Length; i++)
            {
                int rounded;
                if (numbers[i] < 0)
                {
                     rounded =(int)(numbers[i] - 0.5);
                }
                else
                {
                     rounded = (int)(numbers[i] + 0.5);
                }

                //Output
                Console.WriteLine("{0} => {1}",numbers[i],rounded);
            }
        }
    }
}
