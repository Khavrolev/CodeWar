using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = Kata.High("what time are we climbing up to the volcano");
            Console.WriteLine(test);

            Console.ReadKey();
        }

        public static class Kata
        {
            public static string High(string s)
            {
                string[] words = s.Split(" ");
                int max = 0;
                string result = "";

                foreach (string w in words)
                {
                    int sum = 0;
                    char[] letters = w.ToCharArray();

                    foreach (char l in letters)
                    {
                        sum += (int)l - 96;
                    }

                    if (sum > max) { 
                        result = w;
                        max = sum;
                    }
                }

                return result;
            }
        }
    }
}