using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = SquareDigits(9119);
            Console.WriteLine(test);

            Console.ReadKey();
        }

        public static int SquareDigits(int n)
        {
            int result = 0;
            int i = 0;

            do
            {
                int m = n % 10;
                result += (int)(Math.Pow(m, 2) * Math.Pow(10, i));
                i = (m > 3) ? i + 2 : i + 1;
                n /= 10;
            } while (n > 0);

            return result;
        }
    }
}