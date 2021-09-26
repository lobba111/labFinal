using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "29535123p48723487597645723645"; // min start
            BigInteger b = 0;//Håller värdet på alla mina träffar




            for (int i = 0; i < input.Length - 1; i++)
            {

                char c = input[i];

                int index = input.IndexOf(c, i + 1);



                int lenght = index - i + 1;




                if (index != -1)
                {
                    string newHit = input.Substring(i, lenght);
                    if (IsDigitsOnly(newHit))
                    {

                        if (i == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(newHit);
                            Console.ResetColor();
                            Console.Write(input.Substring(index + 1));
                            Console.WriteLine();
                            b += BigInteger.Parse(newHit);

                        }
                        else if (index == input.Length - 1)
                        {
                            Console.Write(input.Substring(0, i));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(newHit);
                            Console.ResetColor();
                            b += BigInteger.Parse(newHit);
                            Console.WriteLine();



                        }
                        else if (i > 0 && index > 0 && index < input.Length - 1)
                        {
                            Console.Write(input.Substring(0, i));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(newHit);
                            Console.ResetColor();
                            Console.Write(input.Substring(index + 1));
                            Console.WriteLine();
                            b += BigInteger.Parse(newHit);

                        }











                    }
                }









            }

            Console.WriteLine("Summan utav alla träffar blir = {0}", b);

        }






        private static bool IsDigitsOnly(string newHit)
        {
            foreach (char c in newHit)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

    }
}
