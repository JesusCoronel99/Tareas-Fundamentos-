using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaValoresTrianguloJesusCoronel
{
    class Program
    {
        static void Main(string[] args)
        {
           
               Console.WriteLine("Digite el valor de b");
               double bgrados = double.Parse(Console.ReadLine());
               Console.WriteLine("Digite el valor de z");
               double z = double.Parse(Console.ReadLine());
               Console.WriteLine("Digite el valor de y");
               double y = double.Parse(Console.ReadLine());

               double b = bgrados * (Math.PI / 180.0);

               double t = Math.Sqrt((z * z) + (y * y));
               double c = Math.Asin(z / t);
               double a = Math.PI - (Math.PI / 2) - c;          
               double d = Math.PI - (Math.PI / 2) - (a + b);
            double x = (z / Math.Tan(d))-y ; 

            Console.WriteLine("El valor de x es " + x);
           
           
        }
    }
}
