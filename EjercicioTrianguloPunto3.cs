using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el valor de w");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de d");
            double dgrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de x");
            double x = double.Parse(Console.ReadLine());

            double d = dgrados * (Math.PI / 180.0);

            double z = w * Math.Sin(d);
            double y = (z / Math.Tan(d)) - x;

            Console.WriteLine("El valor de y es " + y);
        }
    }
}
