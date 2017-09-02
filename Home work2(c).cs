using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum HTTPError { BadRequest = 400, Unauthorized, PaymentRequired, Forbidden, NotFound, MethodNotAllowed, NotAcceptable, ProxyAuthenticationRequired, RequestTimeout, Conflict, Gone };
    class Program
    {
        static void Main()
        {
            //float a, b, c;
            //bool rez;
            //Console.WriteLine("Enter float number, please");
            //a = float.Parse(Console.ReadLine());
            //rez = (a > -5) && (a < 5);
            //Console.WriteLine(rez);
            //Console.WriteLine("Enter float number, please");
            //b = float.Parse(Console.ReadLine());
            //rez = (b > -5) && (b < 5);
            //Console.WriteLine(rez);
            //Console.WriteLine("Enter float number, please");
            //c = float.Parse(Console.ReadLine());
            //rez = (c > -5) && (c < 5);
            //Console.WriteLine(rez);

            //int a, b, c, rez;

            //Console.WriteLine("Enter 3 integer number, please ");
            //a = Int32.Parse(Console.ReadLine());
            //b = Int32.Parse(Console.ReadLine());
            //c = Int32.Parse(Console.ReadLine());

            //rez = (a > c && a > b) ? a : (b > c && b > a) ? b :  c;

            //Console.WriteLine("The Biggest number is {0}",rez);

            Console.WriteLine("Enter number of an error");
            int d = int.Parse(Console.ReadLine());
            HTTPError rez = (HTTPError)d;
            Console.WriteLine("{0} is error cause of {1}.", d, rez);




        }
    }
}
