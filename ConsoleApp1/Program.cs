using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = Kata.MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Console.WriteLine(test);

            Console.ReadKey();
        }

        public static class Kata
        {
            public static int MaxSequence(int[] arr)
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    int preSum = 0;
                    for (int j = i; j < arr.Length; j++)
                    {
                        preSum += arr[j];
                        if (preSum > sum)
                            sum = preSum;
                    }
                }
                return sum;
            }
        }
    }
}