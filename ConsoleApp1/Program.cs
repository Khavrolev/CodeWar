using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = Kata.StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" });
            Console.WriteLine(test);
            //foreach (string t in test)
            //{
            //    Console.Write(t + " ");
            //}


            Console.ReadKey();
        }

        public static class Kata
        {
            public static string StripComments(string text, string[] commentSymbols)
            {
                string[] lines = text.Split("\n");
                List<string> changedLines = new List<string>();

                foreach (string line in lines)
                {
                    string changedLine = line;
                    foreach (string symbol in commentSymbols)
                    {
                        if (line.IndexOf(symbol) > -1)
                            changedLine = line.Substring(0, line.IndexOf(symbol));
                    }

                    changedLines.Add(changedLine.TrimEnd());
                }

                return String.Join("\n", changedLines);
            }
        }
    }
}