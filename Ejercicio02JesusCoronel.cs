using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valores de 1 y 0");
            Console.WriteLine("Digite el valor de b0");
            int b0 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de b1");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de b2");
            int b2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de b3");
            int b3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de b4");
            int b4 = int.Parse(Console.ReadLine());

            double b0d = b0 * Math.Pow(2,4);
            double b1d = b1 * Math.Pow(2, 3);
            double b2d = b2 * Math.Pow(2, 2);
            double b3d = b3 * Math.Pow(2, 1);
            double b4d = b4 * Math.Pow(2, 0);

            double Numero = b4d + b3d +b2d + b1d + b0d;
            Console.WriteLine("su numero es " + Numero);
        }
    }
}
