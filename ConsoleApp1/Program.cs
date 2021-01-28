using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> test = Kata.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } });
            Console.WriteLine(test);

            Console.ReadKey();
        }

        public static class Kata
        {
            public static IEnumerable<string> OpenOrSenior(int[][] data)
            {
                List<string> status = new List<string>();
                foreach (int[] person in data)
                {
                    if (person[0] >= 55 && person[1] > 7)
                        status.Add("Senior");
                    else
                        status.Add("Open");
                }
                IEnumerable<string> ie = status;

                return ie;
            }
        }
    }
}