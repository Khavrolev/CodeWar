using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = SpinWords("Hey fellow warriors");
            Console.WriteLine(test);

            Console.ReadKey();
        }

        static string SpinWords(string sentence)
        {
            string[] arrSentence = sentence.Split(" ");
            
            for (int i = 0; i < arrSentence.Length; i++)
            { 
                char[] arrWord = arrSentence[i].ToCharArray();
                if (arrWord.Length >= 5)
                {
                    string newWord = "";
                    for (int j = arrWord.Length - 1; j >= 0; j--)
                    {
                        newWord += arrWord[j];
                    }
                    arrSentence[i] = newWord;
                }
            }

            return String.Join(" ", arrSentence);
        }
    }
}



