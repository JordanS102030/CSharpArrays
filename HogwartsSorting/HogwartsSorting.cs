using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogwartsSorting
{
    class HogwartsSorting
    {
        static void Main(string[] args)
        {

            //Input
            int students = int.Parse(Console.ReadLine());

            //Logic
            int gryffindor = 0;
            int slytherin = 0;
            int ravenclaw = 0;
            int hufflepuff = 0;

            for (int i = 0; i < students; i++)
            {
                string[] names = Console.ReadLine().Split(' ').ToArray();
                string firstName = names[0];
                string lastName = names[1];
                int sumAscii = 0;
                for (int letter = 0; letter < firstName.Length; letter++)
                {
                    sumAscii += firstName[letter];
                }
                for (int letter = 0; letter < lastName.Length; letter++)
                {
                    sumAscii += lastName[letter];
                }
                string facultyNumber = string.Format("{0}{1}{2}", sumAscii, firstName[0], lastName[0]);
                int reminder = sumAscii  % 4;
                if (reminder == 0)
                {
                    gryffindor++;
                    Console.WriteLine("Gryffindor {0}",facultyNumber);
                }
                if (reminder == 1)
                {
                    slytherin++;
                    Console.WriteLine("Slytherin {0}",facultyNumber);
                }
                if (reminder == 2)
                {
                    ravenclaw++;
                    Console.WriteLine("Ravenclaw {0}", facultyNumber);
                }
                if (reminder == 3)
                {
                    hufflepuff++;
                    Console.WriteLine("Hufflepuff {0}", facultyNumber);
                }
            }

            //Output
            Console.WriteLine();
            Console.WriteLine("Gryffindor: {0}",gryffindor);
            Console.WriteLine("Slytherin: {0}", slytherin);
            Console.WriteLine("Ravenclaw: {0}", ravenclaw);
            Console.WriteLine("Hufflepuff: {0}", hufflepuff);
        }
    }
}
