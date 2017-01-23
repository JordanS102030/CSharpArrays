using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStrings
{
    class ReverseStrings
    {
        static void Main(string[] args)
        {
            // Write a program to read an array of strings, reverse it and print its elements. The input consists of a sequence of
            // space separated strings. Print the output on a single line(space separated). 

            //Input:a b c d e => Output: e d c b a



            //FIRST SOLUTION 
            //Input
            //string[] letter = Console.ReadLine().Split(' ').ToArray();

            //Simple logic
            //for (int i = 0; i < letter.Length/2 ; i++)
            //{
            //    var old = letter[i];
            //    letter[i] = letter[letter.Length - 1 - i];
            //    letter[letter.Length - 1 - i] = old;
            //}

            //Output
            //Console.WriteLine(string.Join(" ",letter));

            //------------------------------------------------------------------------------------------------

            //SECOND SOLUTION 
            //Input
            //string[] letter = Console.ReadLine().Split(' ').ToArray();

            //Simple logic

            //for (int i = letter.Length-1; i >= 0; i--)
            //{
            //    Console.Write(letter[i]+" ");
            //}


            //------------------------------------------------------------------------------------------------

            //Third SOLUTION 
            // Console.WriteLine(string.Join(" ",Console.ReadLine().Split(' ').Reverse().ToArray()));


            //------------------------------------------------------------------------------------------------

            // SOLUTION 
            //Input
            string[] letter = Console.ReadLine().Split(' ').ToArray();

            //Simple logic
            var reverse = letter.Reverse().ToArray();

            //Output

            Console.WriteLine(string.Join(" ",reverse));
        }
    }
}
