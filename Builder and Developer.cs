using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    interface IDeveloper

    {
        string Tool
        {
            get;
            set;
        }
        void create();
        void destroy();

       
    }
    public class Programmer : IDeveloper
    {
        
        public string Tool { get; set; }

        public Programmer(string language)
        {
            Tool = language;
        }
            


        public void destroy()
        {
            Console.WriteLine("i was writing code with {0} and somehow i destroy my keyboard",Tool);
        }
        public void create()
        {
            Console.WriteLine("I just create some code");
        }
    }
    public class Builder : IDeveloper
    {
        
        public string Tool { get; set; }
        public Builder(string tool)
        {
            Tool = tool;
        }


        public void destroy()
        {
            Console.WriteLine("I just use {0} and have destroyed a kitchen, where the closet Bus Stop to Mexico",Tool);
        }
        public void create()
        {
            Console.WriteLine("I just creat a wall");
        }
    }




}
