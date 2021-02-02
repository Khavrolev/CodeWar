using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = Kata.Determinant(new int[][] { new[] { 10, -10, 2, 7, -3, -6 }, new[] { -8, 5, 4, -8, 10, -7 }, new[] { 0, 6, -2, 7, 7, 5 }, new[] { -6, -10, 3, -9, 2, -2 }, new[] { 8, -4, -1, 2, 1, -10 }, new[] { -3, 4, 1, 0, 10, 6 } });
            //int test = Kata.Determinant(new int[][] { new[] { 1 } });
            Console.WriteLine(test);
            //foreach (string t in test)
            //{
            //    Console.Write(t + " ");
            //}


            Console.ReadKey();
        }

        public static class Kata
        {
            public static int Determinant(int[][] matrix)
            {
                int det = 0;
                int[][] cutMatrix;
                int k;
                List<int> result;

                if (matrix.Length == 1)
                    det = matrix[0][0];
                else
                {
                    int size = matrix[0].Length;
                    for (int i = 0; i < size; i++)
                    {
                        cutMatrix = new int[size - 1][];
                        k = (-2 * (i % 2) + 1) * matrix[0][i];

                        for (int j = 0; j < size - 1; j++)
                        {
                            result = matrix[j + 1].ToList();
                            result.RemoveAt(i);
                            cutMatrix[j] = result.ToArray();
                        }
                        
                        det += k * Determinant(cutMatrix);
                    }
                }
                return det;
            }
        }
    }
}