using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMinMaxFirst_LastAveragee
{
    class SumMinMaxFirst_LastAveragee
    {
        static void Main(string[] args)
        {
            //Write a program to read n integers and print their sum, min, max, first, last and average values.
            //Input: 5 => Ouput:
            //12             Sum = 72
            //20             Min = -5
            //- 5            Max = 37
            //37             First = 12
            //8              Last = 8
            //               Average= 14.4


            //Input
            int number = int.Parse(Console.ReadLine());
            int[] result = new int[number];

            //Simple logic

            int sum = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
         
            for (int i = 0; i < number; i++)
            {
                result[i] = int.Parse(Console.ReadLine());
                sum += result[i];
                if (result[i] < min)
                {
                    min = result[i];
                }
                max = Math.Max(max, result[i]);
            }

            //FIRST SOLUTION 
            //Output
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Min = {0}", min);
            Console.WriteLine("First = {0}", result[0]);
            Console.WriteLine("Max = {0}", max);
            Console.WriteLine("Last = {0}", result[result.Length - 1]);
            Console.WriteLine("Average = {0}", (double)sum / number);

            //SECOND SOLUTION 

            //Input
            //int number = int.Parse(Console.ReadLine());
            //int[] result = new int[number];

            //Output
            //Console.WriteLine("Sum = {0}", result.Sum());
            //Console.WriteLine("Min = {0}", result.Min());
            //Console.WriteLine("First = {0}", result.First());
            //Console.WriteLine("Max = {0}", result.Max());
            //Console.WriteLine("Last = {0}", result.Last());
            //Console.WriteLine("Average = {0}", result.Average());
        }
    }
}
