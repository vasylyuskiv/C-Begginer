using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static ConsoleApp13.Shape;

namespace ConsoleApp13
{
    abstract public class Shape
    {
        public string name;

        public Shape(string name)
        {
            this.name = name;
        }
        abstract public double Perimeter();

        abstract public double Area();


        virtual public string Name
        {
            get { return Name; }
            set { Name = value; }

        }
    }
        public class Circle : Shape

        {
            public double radius;

            public Circle(string name, double radius) : base(name)
            {
                this.radius = radius;
            }
            override public string Name { get { return base.Name + " Circle"; } }
            public override double Perimeter()
            {
                double circper = 2 * Math.PI * radius;
                return circper;


                throw new NotImplementedException();
            }
            public override double Area()
            {
                double A = Math.PI * radius * radius;
                return A;
                throw new NotImplementedException();
            }
        

        }
        public class Square : Shape
        {

            public double side;

            public Square(string name, double side) : base(name)
            {
                this.side = side;
            }
            override public string Name { get { return base.Name + " Square"; } }


            public override double Perimeter()
            {
                double persq = 4 * side;
                return persq;
                throw new NotImplementedException();
            }
            public override double Area()
            {
                double SqArea = side * side;
                return SqArea;
                throw new NotImplementedException();
            }

        
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> formy = new List<Shape>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter the Raius of a Circle  ");
                double imput = double.Parse(Console.ReadLine());

                formy.Add(new Circle("kolo", imput));
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Length of the side of a Square  ");
                double imput = double.Parse(Console.ReadLine());

                formy.Add(new Square("Kvadrat", imput));
            }


            string l = string.Join(",", formy.ToList());
            Console.WriteLine(l);

            //foreach (var r in formy)
            //{
            //    Console.WriteLine("it works");
            //}
        }


        //formy.Add(new Circle("Kolo", input));
        //formy.Add(new Circle("Kolo", 7));
        //formy.Add(new Circle("Kolo", 3.555));
        //formy.Add(new Circle("Kolo", 4.868));
        //formy.Add(new Circle("Kolo", 7889));


        //formy.Add(new Square("Kvadrat", 5));
        //formy.Add(new Square("Kvadrat", 8));
        //formy.Add(new Square("Kvadrat", 7));
        //formy.Add(new Square("Kvadrat", 5555));
        //formy.Add(new Square("Kvadrat", 88));







    }
}

