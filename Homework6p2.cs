using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6p2
{
    class Program
    {
        static int ReadNumber(int start, int end, int p)
        {


            int a = Int32.Parse(Console.ReadLine());

            if ((a < start) || (a > end))
            {
                throw new ArgumentOutOfRangeException();
            }

            return a;
        }

        static void Main(string[] args)
        {
            try
            {
                for (int p = 1; p <= 10; p++)
                {
                    Console.Write("Enter number in the rangefrom 1 to 10 : ");
                    int a = ReadNumber(1, 100, p);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("The number is NOT integer!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Null is NOT integer.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is NOT in the range of integer.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number is NOT in the range.");
            }



        }
    }
}


