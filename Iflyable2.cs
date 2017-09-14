using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    interface Iflyable
    {
        void fly();

    }
    public class Bird : Iflyable
    {
        private string name;
        private bool canFly = true;

        public void fly()
        {
            if (canFly)
            Console.WriteLine("i'm bird {0} i can fly", name);
            else
                Console.WriteLine("i'm bird {0} i can't fly", name);

        }
    }
    public class Plane : Iflyable
    {
        private string mark="boeing";
        private int highFly=5;

        public void fly()
        {
            if (highFly>3)
                Console.WriteLine("i'm plane {0} i can fly high", mark);
            else
                Console.WriteLine("i'm bird {0} im flying not so high", mark);

        }
    }
}

