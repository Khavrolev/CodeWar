using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = Kata.sumStrings("50095301248058391139327916261", "81055900096023504197206408605");
            Console.WriteLine(test);
            //foreach (string t in test)
            //{
            //    Console.Write(t + " ");
            //}


            Console.ReadKey();
        }

        public static class Kata
        {
            public static string sumStrings(string a, string b)
            {
                if (a == "")
                    a = "0";
                if (b == "")
                    b = "0";

                string stringA1 = "";
                string stringA2 = "";
                string stringB1 = "";
                string stringB2 = "";

                for (int i = 0; i < a.Length; i++)
                {
                    if (a.Length - i > 18)
                        stringA1 += a[i];
                    else
                        stringA2 += a[i];
                }

                for (int i = 0; i < b.Length; i++)
                {
                    if (b.Length - i > 18)
                        stringB1 += b[i];
                    else
                        stringB2 += b[i];
                }

                ulong ulongAB1 = ((stringA1 == "") ? 0 : UInt64.Parse(stringA1)) + ((stringB1 == "") ? 0 : UInt64.Parse(stringB1));
                ulong ulongAB2 = UInt64.Parse(stringA2) + UInt64.Parse(stringB2);

                ulongAB1 = (ulongAB2 / 1000000000000000000 > 0) ? ulongAB1 + 1 : ulongAB1;
                ulongAB2 = (ulongAB2 / 1000000000000000000 > 0) ? ulongAB2 % 1000000000000000000 : ulongAB2;

                string stringAB1 = (ulongAB1 == 0) ? "" : ulongAB1.ToString();
                string stringAB2 = ((ulongAB2 / 100000000000000000 == 0 && ulongAB1 != 0) ? "0" : "") + ulongAB2.ToString();

                return stringAB1 + stringAB2;
            }
        }
    }
}