using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = Kata.CountSmileys(new string[] { ":D", ":~)", ";~D", ":)" });
            Console.WriteLine(test);
            //foreach (string t in test)
            //{
            //    Console.Write(t + " ");
            //}


            Console.ReadKey();
        }

        public static class Kata
        {
            public static int CountSmileys(string[] smileys)
            {
                if (smileys.Length == 0)
                    return 0;

                string face = ":;";
                string nose = "-~";
                string mouth = ")D";
                int counter = 0;

                foreach (string smile in smileys)
                {
                    if (smile.Length < 2)
                        continue;

                    if (!face.Contains(smile[0]))
                        continue;

                    if (smile.Length == 2)
                    {
                        if (!mouth.Contains(smile[1]))
                            continue;
                    }
                    else if (smile.Length == 3)
                    {
                        if (!nose.Contains(smile[1]))
                            continue;
                        if (!mouth.Contains(smile[2]))
                            continue;
                    }

                    counter++;
                }

                return counter;
            }
        }
    }
}