using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Person
    {
        private string name;
        private int birthYear;

        private int BirthYear
        {
            get
            {
                return birthYear;
            }
        }
        private string Name
        {
            get
            {
                return name;
            }

        }
        public Person()
        {
        }
        public Person(string n, int by)
        {
            n = name;
            by = birthYear;
        }
        public int Age()
        {
            if(birthYear < 0)
            {
                return birthYear;
            }
            int cy = 2017;
            int age = cy - birthYear;
            return age;
            
            
        }
        public void Input()
        {
            Console.WriteLine("Enter Your Name, please: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Year of your birth: ");
            birthYear = int.Parse(Console.ReadLine());

        }
        public void ChangeName()
        {
            
            Console.WriteLine("Change ur name:");
            string namechan = Console.ReadLine();
            name = namechan;
        }
        //public void ToString()
        //{
        //}
        public void Output()
        {
            Console.WriteLine("person {0} was born in {1} and has age ", name,birthYear);
        }
        public void sameName()
        {
            if (name==Name)
            {
                Console.WriteLine("same name {0}",Name);
            }

        }
    }     
    class Program
    {
        static void Main()
        {
            Person pers1 = new Person();
            Person pers2 = new Person();
            Person pers3 = new Person();
            Person pers4 = new Person();
            Person pers5 = new Person();
            Person pers6 = new Person();
            pers1.Input();
            pers1.Output();
            Console.WriteLine (pers1.Age());
            pers1.ChangeName();
            pers1.Output();
            Console.WriteLine(pers1.Age());
            pers2.Input();
            pers3.Input();
            pers4.Input();
            pers5.Input();
            pers6.Input();
           



        }
    }
}
