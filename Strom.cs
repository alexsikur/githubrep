using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Strom
    {
        public Strom() { }
        ~Strom() { }
        public double Volume
        {
            get {return Math.PI * (r * r) * h / 3; }
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
