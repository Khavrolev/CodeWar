using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = Kata.bouncingBall(3.0, 0.66, 1.5);
            Console.WriteLine(test);
            //foreach (string t in test)
            //{
            //    Console.Write(t + " ");
            //}


            Console.ReadKey();
        }

        public static class Kata
        {
            public static int bouncingBall(double h, double bounce, double window)
            {
                if (h <= 0 || bounce <= 0 || bounce >= 1 || window >= h)
                    return -1;

                int result = 1;
                h *= bounce;

                while (h > window)
                {
                    result += 2;
                    h *= bounce;
                }

                return result;
            }
        }
    }
}