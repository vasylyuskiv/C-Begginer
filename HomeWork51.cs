using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> idbank = new Dictionary<uint, string>();


            // неправильно зрозумів завдання на початках 

            //Console.WriteLine("Hello enter ID of a Person and a name");
            //idbank.Add(uint.Parse(Console.ReadLine()), Console.ReadLine());
            //Console.WriteLine("Hello enter ID of a Person and a name");
            //idbank.Add(uint.Parse(Console.ReadLine()), Console.ReadLine());
            //Console.WriteLine("Hello enter ID of a Person and a name");
            //idbank.Add(uint.Parse(Console.ReadLine()), Console.ReadLine());
            //Console.WriteLine("Hello enter ID of a Person and a name");
            //idbank.Add(uint.Parse(Console.ReadLine()), Console.ReadLine());
            //Console.WriteLine("Hello enter ID of a Person and a name");
            //idbank.Add(uint.Parse(Console.ReadLine()), Console.ReadLine());
            //Console.WriteLine("Hello enter ID of a Person and a name");
            //idbank.Add(uint.Parse(Console.ReadLine()), Console.ReadLine());
            //Console.WriteLine("Hello enter ID of a Person and a name");
            //idbank.Add(uint.Parse(Console.ReadLine()), Console.ReadLine());

            idbank.Add(1, "Petro");
            idbank.Add(2, "Ivan");
            idbank.Add(3, "Marichka");
            idbank.Add(4, "Zenyk");
            idbank.Add(5, "Mykola");
            idbank.Add(6, "Ira");
            idbank.Add(7, "Ania");
            idbank.Add(8, "Syrnyk");

            Console.WriteLine("Hello Enter the ID of the person, please");
            uint r = uint.Parse(Console.ReadLine());

            if (r < 8)
            {
                Console.WriteLine(idbank[r]);
            }
            else
            {
                Console.WriteLine("there is no such ID in our base");

            }




        }
    }
}
