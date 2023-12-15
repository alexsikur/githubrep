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
        interface IOrganizmus
        {
            void rastie();
        }
        class Strom : IOrganizmus
        {
            public virtual void rastie()
            {

            }
            public Strom() { }
            ~Strom() { Console.WriteLine("destructor"); }
            public virtual double Volume
            {
                get { return Math.PI * (r * r) * h / 3; }
            }
            public double r;
            public double h;
        }
       //dedicnost, enkapsulacia, polyformizmus
       //ako je v kode dedicnost - (class Baobab:Leaf)
       //objekt je instanciou triedy/ je hmotny 
       //trieda je predpis ako sa ma objekt vytvarat
       //polyformizmus -  override
       //enkapsulacia - public, private, protected
       //interface - je specialny druh triedy ktora ma deklaraciu a nie definiciu
       //            
        class Baobab : Strom
        {
            public Baobab() { }
            ~Baobab() { }

            public override double Volume
            {
                get { return Math.PI * (r * r) * h; }
            }
        }
        static void Main(string[] args)
        {
            Strom strom1= new Strom();
            Baobab strom2 = new Baobab();


            double r;
            double h;
            double v = 0;
            double c = 0;


            for (int i = 0; i < 2; i++)
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
            Console.WriteLine();
            Console.ReadLine();

        }


    }

}
