using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = Kata.inArray(new string[] { "arp", "live", "strong" }, new string[] { "lively", "alive", "harp", "sharp", "armstrong" });
//            Console.WriteLine(test);
            foreach (string t in test)
            {
                Console.Write(t + " ");
            }


            Console.ReadKey();
        }

        public static class Kata
        {
            public static string[] inArray(string[] array1, string[] array2)
            {
                List<string> res = new List<string>();

                foreach (string sub in array1)
                {
                    foreach (string word in array2)
                    {
                        if (word.Contains(sub))
                        {
                            res.Add(sub);
                            break;
                        }   
                    }
                }

                string[] arr = res.ToArray();
                Array.Sort(arr);

                return arr;
            }
        }
    }
}