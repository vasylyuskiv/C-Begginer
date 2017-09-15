using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            List<IDeveloper> list = new List<IDeveloper>();
            list.Add(new Programmer("C++"));
            list.Add(new Builder("hummer"));

            foreach (var c in list)
                c.create();
            foreach (var d in list)
                d.destroy();

            //Programmer programmer = new Programmer("c++");
            //programmer.create();
            //programmer.destroy();

            //Builder builder = new Builder("hummer");
            //builder.create();
            //builder.destroy();




        }
    }
}
