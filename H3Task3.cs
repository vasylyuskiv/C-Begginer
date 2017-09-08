using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            int[] tenNumb = new int[10];
            int sum;
            for (int i=0; i< tenNumb.Length; i++)
            {
                tenNumb[i] = Int32.Parse(Console.ReadLine());
            }
            sum = tenNumb[0] + tenNumb[1] + tenNumb[2] + tenNumb[3] + tenNumb[4];
            int sum2 = tenNumb[5] + tenNumb[6] + tenNumb[7] + tenNumb[8] + tenNumb[9];

            if (sum < 0)
            {
                Console.WriteLine("sum of last 5 numbers is: {0}", sum2);
            }
            else
            {
                Console.WriteLine("sum of first 5 numbers is: {0}", sum);
            }
            

        }
    }
}
