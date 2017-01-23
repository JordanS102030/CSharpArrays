using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSum
{
    class LastKNumbersSum
    {
        static void Main(string[] args)
        {
            //Enter two integers n and k. Generate and print the following sequence of n elements:
            //The first element is: 1
            // All other elements = sum of the previous k elements(if less than k are available, sum all of them)
            // Example: n = 9, k = 5  120 = 4 + 8 + 16 + 31 + 61
            //Input:6    => Output:  1 1 2 4 7 13
            //      3   

            //Input
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            //Logic
            decimal[] sequence = new decimal[n];
            sequence[0] = 1;
            for (int i = 0; i < n; i++)
            {
                decimal sum = 0;
                for (int currentElement = i-k; currentElement <= i-1; currentElement++)
                {
                    if (currentElement >= 0)
                    {
                        sum += sequence[currentElement];
                        sequence[i] = sum;
                    }
                }
            }
            //Output
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
