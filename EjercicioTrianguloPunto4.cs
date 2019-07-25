using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el valor de w");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de t");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de c");
            double cgrados = double.Parse(Console.ReadLine());

            double c = cgrados * (Math.PI / 180.0);

            double z = Math.Sin(c) * t;
            double y = Math.Cos(c) * t;
            double d = Math.Asin(z / w);
            double x = (z / Math.Tan(d)) - y;
            Console.WriteLine("El valor de x es " + x);
        }
    }
}
