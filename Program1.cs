﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r;
            double h;
            double v = 0;

            Console.WriteLine("Zadaj radius:");
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj vysku:");
            h = double.Parse(Console.ReadLine());
            v = Math.PI*(r*r)*h / 3;
            Console.WriteLine(v);
            Console.ReadLine();
            
        }
    }
}