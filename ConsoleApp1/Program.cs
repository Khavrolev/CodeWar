using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = MorseCodeDecoder.Decode(".... . -.--   .--- ..- -.. .");
            Console.WriteLine(test);

            Console.ReadKey();
        }

        class MorseCodeDecoder
        {
            public static string Decode(string morseCode)
            {
                morseCode = morseCode.Trim().Replace("   ", " | ");
                string[] arrMorse = morseCode.Split(" ");

                for (int i = 0; i < arrMorse.Length; i++)
                {
                    if (arrMorse[i] != "|")
                        arrMorse[i] = MorseCode.Get(arrMorse[i]);
                    else
                        arrMorse[i] = " ";
                }

                return String.Join("", arrMorse);
            }
        }
    }
}