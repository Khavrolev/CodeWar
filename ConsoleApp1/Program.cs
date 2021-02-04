using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = Kata.MixedFraction("64/-50");
            Console.WriteLine(test);
            //foreach (string t in test)
            //{
            //    Console.Write(t + " ");
            //}


            Console.ReadKey();
        }

        public static class Kata
        {
            public static string MixedFraction(string s)
            {
                string[] arrS = s.Split("/");
                long i1 = Int64.Parse(arrS[0]);
                long i2 = Int64.Parse(arrS[1]);

                if (i2 == 0)
                    return (0 / i2).ToString();
                else if (i1 == 0)
                    return "0";
                else if (i1 % i2 == 0)
                    return (i1 / i2).ToString();
                else
                {
                    long counter = 2;
                    long number = i1 / i2;
                    while (counter <= Math.Abs(i2) / 2)
                    {
                        if (i1 % counter == 0 && i2 % counter == 0)
                        {
                            i1 /= counter;
                            i2 /= counter;
                        }
                        else
                            counter++;
                    }
                    if ((i1 * i2) > 0)
                    {
                        i1 = Math.Abs(i1);
                        i2 = Math.Abs(i2);

                        if (i1 < i2)
                            return (i1 % i2).ToString() + "/" + i2.ToString();

                        else
                            return number.ToString() + " " + (i1 % i2).ToString() + "/" + i2.ToString();
                    }
                    else
                    {
                        i1 = Math.Abs(i1);
                        i2 = Math.Abs(i2);

                        if (i1 < i2)
                            return (-i1 % i2).ToString() + "/" + i2.ToString();
                        else
                            return number.ToString() + " " + (i1 % i2).ToString() + "/" + i2.ToString();
                    }
                }
            }
        }
    }
}