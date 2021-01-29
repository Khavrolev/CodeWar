using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = Kata.MakeComplement("AAAA");
            Console.WriteLine(test);

            Console.ReadKey();
        }

        public static class Kata
        {
            public static string MakeComplement(string dna)
            {
                char[] code = dna.ToCharArray();
                string side = "";
                foreach (char letter in code)
                {
                    side += (letter == 'A') ? 'T' : (letter == 'T') ? 'A' : (letter == 'C') ? 'G' : (letter == 'G') ? 'C' : 'K';
                }
                return side;
            }
        }
    }
}