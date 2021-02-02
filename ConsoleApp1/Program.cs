using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = Kata.Score(new int[] { 4, 4, 4, 3, 3 });
            Console.WriteLine(test);
            //foreach (string t in test)
            //{
            //    Console.Write(t + " ");
            //}


            Console.ReadKey();
        }

        public static class Kata
        {
            public static int Score(int[] dice)
            {
                int[] score = new int[6];
                int result = 0;

                foreach (int side in dice)
                {
                    score[side - 1]++;
                }

                for (int i = 0; i < score.Length; i++)
                {
                    while ((score[i] / 3) > 0)
                    {
                        result += (i + 1) * ((i == 0) ? 1000 : 100);
                        score[i] -= 3;
                    }

                    result += score[i] * ((i == 0) ? 100 : (i == 4) ? 50 : 0);
                }

                return result;
            }
        }
    }
}