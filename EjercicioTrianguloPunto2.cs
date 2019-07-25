using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el valor de d");
            double dgrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de b");
            double bgrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de y");
            double y = double.Parse(Console.ReadLine());

            double d = dgrados * (Math.PI / 180.0);
            double b = bgrados * (Math.PI / 180.0);

            double e = Math.PI - (d + b);
            double c = Math.PI - e;
            double cgrados = c * (180.0 / Math.PI);
            double z = Math.Tan(c) * y;

            Console.WriteLine("El valor de z es " + z);
        }
    }
}
