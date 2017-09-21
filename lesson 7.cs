using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    public class Person
    {
        private string name;
        public Person(string name)
        { this.name = name; }
        virtual public string Name { get { return name; } }
        virtual public void Print()
        {
            Console.WriteLine("Name: {0}", this.name);
        }
    }
    public class Staff : Person
    {
        private int salary;
        public Staff(string name, int salary) : base(name)
        { this.salary = salary; }
        override public string Name { get { return base.Name + "Staff"; } }
        override public void Print()
        {
            Console.WriteLine("Person {0} has salary: ${1}", Name, this.salary);
        }
        public class Teacher : Staff
        {
            private string subject;
            public Teacher(string name, int salary, string sub) : base(name, salary)
            {
                subject = sub;
            }

            override public void Print()
            {
                base.Print();
                Console.WriteLine("subject of a teacher {0}", subject);
            }
        }

        class Program
        {


            static void Main(string[] args)
            {
                List<Person> people = new List<Person>();
                char answer ='r';
                while (answer != 'n')
                {
                    Console.WriteLine("enter s for staff, p for person, t for teacher, n for exit");
                    answer = Char.Parse(Console.ReadLine());
                    switch (answer)
                    {
                        case 'p': people.Add(new Person("Ivan")); break;
                        case 's': people.Add(new Staff("Olia", 100)); break;
                        case 't': people.Add(new Teacher("Fedia", 200, "C#")); break;

                    }
                }
                foreach (var p in people)
                    p.Print();
                //List<Person> people = new List<Person>();
                //people.Add(new Person("Yura"));
                //people.Add(new Staff("Ira", 300));
                //foreach (var p in people)
                //    p.Print();
            }
        }

    }
}
