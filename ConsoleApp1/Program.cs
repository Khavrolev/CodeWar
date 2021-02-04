using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> test = Kata.Count("aaaa");
            Console.WriteLine(test);
            //foreach (string t in test)
            //{
            //    Console.Write(t + " ");
            //}


            Console.ReadKey();
        }

        public static class Kata
        {
            public static Dictionary<char, int> Count(string str)
            {
                Dictionary<char, int> d = new Dictionary<char, int>();

                foreach(char c in str)
                {
                    if (!d.ContainsKey(c))
                        d.Add(c, 1);
                    else
                        d[c]++;
                }

                return d;
            }
        }
    }
}