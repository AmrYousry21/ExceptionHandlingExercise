using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };
            List<int> numbers = new List<int>();
            string str = "";
            
            foreach(char c in chars) 
            {
                try
                {
                    str = c.ToString();
                    int num = int.Parse(str);
                    numbers.Add(num);
                }
                catch (Exception)
                {
                    Console.WriteLine($"Unable to Parse '{c}'");
                }
            }


            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
