using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = Kata.GetVowelCount("abracadabra");
            Console.WriteLine(test);

            Console.ReadKey();
        }

        public static class Kata
        {
            public static int GetVowelCount(string str)
            {
                int vowelCount = 0;
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                char[] letters = str.ToCharArray();

                foreach (char letter in letters)
                {
                    if (Array.Exists(vowels, element => element == letter))
                        vowelCount++;
                }

                return vowelCount;
            }
        }
    }
}