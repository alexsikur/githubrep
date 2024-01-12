using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r;
            double h;
            double v = 0;
            double c = 0;


            Console.WriteLine("Zadaj radius:");
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj vysku:");
            h = double.Parse(Console.ReadLine());
            v = Math.PI * (r * r) * h / 3;
            Console.WriteLine(v);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Zadaj radius:");
                r = double.Parse(Console.ReadLine());
                Console.WriteLine("Zadaj vysku:");
                h = double.Parse(Console.ReadLine());
                v = Math.PI * (r * r) * h / 3;
                c = v + c;
                Console.WriteLine(v);

            }
            Console.WriteLine(c);

            Console.ReadLine();
        }
    }
    class Strom
    {
        public Strom() { }
        ~Strom() { }
        public double Volume
        {
            get { return Math.PI * (r * r) * h / 3; }
        }
        protected double r;
        private double h;
    }
    class Baobab : Strom
    {
        public double Volume
        {
            get { return Math.PI * (r * r) * h; }
        }
        protected double r;
        private double h;
    }
    class ihlicnan : Strom
    {
        public double Volume
        {
            get { return Math.PI * (r * r) * h; }
        }
        protected double r;
        private double h;
    }
}
