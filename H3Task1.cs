using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()

        { //Homework 3 Task1
            int LichA = 0;
            int LichO = 0;
            int LichE = 0;
            int LichI = 0;
            Console.WriteLine("Enter your text here");

            string s = Console.ReadLine();
            foreach (Char a in s)
            {
                if (a == 'a')
                {
                    LichA++;

                }
                if (a == 'i')
                {
                    LichI++;
                }
                if (a == 'e')
                {
                    LichE++;
                }
                if (a == 'o') { LichO++; }
            }
            Console.WriteLine("Letters A in text {0}, Letters I in text {1}, Letters E in text {2}, Letters O in text {3}", LichA, LichI, LichE, LichO);
        }
    }
}
