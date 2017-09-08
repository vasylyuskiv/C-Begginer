using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            int[] longmonth = new int[7] { 1, 3, 5, 7, 8, 10, 12 };
            int[] shortmonth = new int[4] { 4, 6, 9, 11 };
            int[] feb = new int[1] { 2 };


            Console.WriteLine("Hello, Please, enter the number of the month");
            int mon = int.Parse(Console.ReadLine());

            foreach (int x in longmonth)
            {
                if (x == mon)
                {
                    Console.WriteLine("In this month 31 days");
                }

            }
            foreach (int y in shortmonth)
            {
                if (y == mon)
                {
                    Console.WriteLine("In this month 30 days");
                }
            }
            foreach (int z in feb)
            {
                if (z == mon)
                {
                    Console.WriteLine("In this month 28 or 29 days");
                }
            }





        }
    }
}

