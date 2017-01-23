using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfTheWeek
{
    class DaysOfTheWeek
    {
        static void Main(string[] args)
        {
            //Enter a day number [1…7] and print the day name (in English) or “Invalid Day!”. Use an array of strings.

            //Input
            string[] daysWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int day = int.Parse(Console.ReadLine());

            //Simple logic

            if(day>=1 && day <= 7)
            {
                Console.WriteLine(daysWeek[day-1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
