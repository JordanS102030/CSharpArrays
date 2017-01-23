using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            //    Jagged arrays, regular expressions, asynchronous programming… Tough stuff. But simple structures like arrays are piece of cake, right? Let’s/ /see how well you can manipulate data in a collection.
            //   You will be given a series of strings on a single line, separated by one or more whitespaces.These represent the collection you’ll be working/ /     with.
            //   On the next input lines, until you receive the command "end", you’ll receive a series of commands in one of the following formats:
            //   "reverse from [start] count [count]" – this instructs you to reverse a portion of the array – just[count] elements starting at index[start];
            //   "sort from [start] count [count]" – this instructs you to sort a portion of the array - [count] elements starting at index[start];
            //   "rollLeft [count] times" – this instructs you to move all elements in the array to the left[count] times.On each roll, the first element is //placed at the end of the array;
            //   "rollRight [count] times" – this instructs you to move all elements in the array to the right[count] times.On each roll, the last element ///is //placed at the beginning of the array;
            //    If any of the provided indices or counts is invalid (non - existent or negative), you should print a message on the console – "Invalid input/ /parameters." and keep the collection unchanged.
            //      After you’re done, print the resulting array in the following format: "[arr0, arr1 … arrN]".The examples should help you understand the //task better.


            //Input : 1 2 5 8 7 3 10 6 4 9
            //reverse from 2 count 4
            //end


            //Input
            char[] separators = { ' ' };
            List<string> input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] command = Console.ReadLine().ToLower().Split();
        
            while (!command[0].Equals("end"))
            {
                switch (command[0])
                {
                    case "reverse":
                        int start = int.Parse(command[2]);
                        int count= int.Parse(command[4]);
                        if (start < 0 || count < 0 || start >= input.Count || start + count > input.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        List<string> newList = input.Skip(start).Take(count).Reverse().ToList();

                        input.RemoveRange(start, count);
                        input.InsertRange(start, newList);
                        break;

                    case "sort":
                        start = int.Parse(command[2]);
                        count = int.Parse(command[4]);
                        if (start < 0 || count < 0 || start >= input.Count || start + count > input.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        newList = input.Skip(start).Take(count).OrderBy(str => str).ToList();

                        input.RemoveRange(start, count);
                        input.InsertRange(start, newList);

                        break;
                    case "rollLeft":
                        count = int.Parse(command[1]);
                        if(count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        for (int i = 0; i < count % input.Count; i++)
                        {
                            string element = input[0];
                            input.RemoveAt(0);
                            input.Add(element);
                        }

                        break;
                    case "rollRight":
                        count = int.Parse(command[1]);
                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        for (int i = 0; i < count % input.Count; i++)
                        {
                            string element = input[input.Count - 1];
                            input.RemoveAt(input.Count - 1);
                            input.Insert(0, element);
                        }
                        break;
                }
                command = Console.ReadLine().ToLower().Split();
            }

            string output = string.Join(", ", input);
            Console.WriteLine("[{0}]",output);
        }
    }
}
