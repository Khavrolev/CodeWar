using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = Accum("ZpglnRxqenU");
            Console.WriteLine(test);

            Console.ReadKey();
        }

        public static string Accum(string s)
        {
            char[] dynS = s.ToCharArray();
            string[] dynResult = new string[dynS.Length];

            for(int i = 0; i < dynS.Length; i++) 
            {
                for (int j = 0; j <= i; j++)
                { 
                    char letter = dynS[i];
                    letter = (j == 0) ? Char.ToUpper(letter) : Char.ToLower(letter);
                    dynResult[i] += letter;
                }
            }

            return String.Join("-", dynResult);
        }
    }
}