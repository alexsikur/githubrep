using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Strom strom1= new Strom();


            double r;
            double h;
            double v = 0;
            double c = 0;


            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("Zadaj radius:");
                r = double.Parse(Console.ReadLine());
                Console.WriteLine("Zadaj vysku:");
                h = double.Parse(Console.ReadLine());
                v = Math.PI * (r * r) * h / 3;
                c = v + c;
                Console.WriteLine("objem je:" + v);

            }
            Console.WriteLine("celkovy objem: " + c);
            Console.ReadLine();

        }

    }
}
