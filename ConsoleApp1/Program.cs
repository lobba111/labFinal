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
            //Console.WriteLine("Skriv in ett tal: ");
            //string input = Console.ReadLine();
            string input = "29535123p48723487597645723645"; // min start
            BigInteger allnumbers = 0;//Håller värdet på alla mina träffar




            for (int i = 0; i < input.Length - 1; i++) 
            {
                char c = input[i];
                int index = input.IndexOf(c, i + 1); //här inne sker sorteringen
                int lenght = index - i + 1;
                if (index != -1)
                {
                    string newHit = input.Substring(i, lenght);// här klipps de matchade träffarna ut
                    if (IsDigitsOnly(newHit))// här kallar jag på en metod för att se att den utklippta strängen bara innehåller siffror
                    {

                        if (i == 0)//nu är det dags att sätta färg på samt skriva ut texten
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;  
                            Console.Write(newHit);
                            Console.ResetColor();
                            Console.Write(input.Substring(index + 1));
                            Console.WriteLine();
                            allnumbers += BigInteger.Parse(newHit);

                        }
                        else if (index == input.Length - 1)
                        {
                            Console.Write(input.Substring(0, i));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(newHit);
                            Console.ResetColor();
                            allnumbers += BigInteger.Parse(newHit);
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
                            allnumbers += BigInteger.Parse(newHit);

                        }











                    }
                }









            }

         Console.WriteLine("Summan utav alla träffar blir = {0}", allnumbers);

        }






        private static bool IsDigitsOnly(string newHit) //här är metoden för att se så att det bara är siffror inne i strängen, är det inte det, kasta,börja om.
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
