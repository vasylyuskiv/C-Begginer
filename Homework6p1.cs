using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main()

        {
            Dictionary<String, long> PhoneBook = new Dictionary<string, long>();
            StreamReader sr = new StreamReader(@"C:\Users\Vasyl\Documents\Visual Studio 2017\Projects\ConsoleApp10\ConsoleApp10\Phones.txt");
            string line;

            while ((line = sr.ReadLine()) != null)
            {

                string[] splitted = line.Split(',');
                string name = splitted[0].Trim();
                long tel = long.Parse(splitted[1].Trim());

                PhoneBook.Add(name, tel);
                foreach (KeyValuePair<string, long> kvp in PhoneBook)
                    Console.WriteLine("User = {0}, number = {1}", kvp.Key, kvp.Value);



                using (StreamWriter PhO = new StreamWriter("PhonesOnly.txt"))
                    foreach (KeyValuePair<string, long> kvp in PhoneBook)
                        PhO.WriteLine("{0}", kvp.Value);

                using (StreamWriter newPh = new StreamWriter("New.txt"))
                    foreach (KeyValuePair<string, long> kvp in PhoneBook)
                        newPh.WriteLine("+3{0}", kvp.Value);



            }

            sr.Close();

            Console.WriteLine("hello please enter Name of the person what are u looking for");
            string ln = Console.ReadLine();

            if (ln != null)
            {
                Console.WriteLine(PhoneBook[ln]);
            }
            else
            {
                //тут тре зробити ще 
                Console.WriteLine("there is no such Person in our base");

            }

        }
    }
}
