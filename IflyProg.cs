using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Iflyable> list = new List<Iflyable>();
            list.Add(new Bird());
            list.Add(new Bird());
            list.Add(new Plane());
            list.Add(new Plane());

            foreach (var c in list)
                c.fly();


        }
    }
}
