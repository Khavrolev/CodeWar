using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = Kata.LongestConsec(new string[] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1);
            Console.WriteLine(test);
            //foreach (string t in test)
            //{
            //    Console.Write(t + " ");
            //}


            Console.ReadKey();
        }

        public static class Kata
        {
            public static string LongestConsec(string[] strarr, int k)
            {
                if (strarr.Length == 0 || k > strarr.Length || k <= 0)
                    return "";

                string result = "";
                int step = 0;

                while (step + k <= strarr.Length)
                {
                    string word = "";
                    for (int i = step; i < step + k; i++)
                    {
                        word += strarr[i];
                    }

                    if (word.Length > result.Length)
                        result = word;

                    step++;
                }

                return result;
            }
        }
    }
}