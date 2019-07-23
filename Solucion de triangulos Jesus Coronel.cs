using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_de_triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
		   Console.WriteLine("Digite el valor de uno de y");
           double y = double.Parse( Console.ReadLine());
           Console.WriteLine("Digite el valor de z");
           double z = double.Parse( Console.ReadLine());        
       

           double t = Math.Sqrt((y*y)+(z*z));

           double agrados = Math.Asin(y/t) * (180.0/Math.PI);
           double cgrados = Math.Asin(z/t) * (180.0/Math.PI);

           Console.WriteLine("el valor de t es" + t );
           Console.WriteLine("el valor del angulo c es" + cgrados);
           Console.WriteLine("el valor del angulo a es" + agrados);
           */
            /*
            Console.WriteLine("Digite el valor de la hipotenusa");
            double t = double.Parse( Console.ReadLine());
            Console.WriteLine("Digite el valor de el angulo de a");
            double agrados = double.Parse( Console.ReadLine());        


            double arad= agrados * (Math.PI/180.0);

            double y = Math.Sin(arad)*t;
            double z = Math.Cos(arad)*t;            
            double cgrados = Math.Asin(z/t) * (180.0/Math.PI);


            Console.WriteLine("esl valor de t es" + t);
            Console.WriteLine("el valor de z es" + z); 
            Console.WriteLine("el valor de cgrados es " + cgrados );
            */


            /*
            
            Console.WriteLine("Digite el valor de z");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de el angulo de c");
            double cgrados = double.Parse(Console.ReadLine());                


            double crad = cgrados * (Math.PI/180.0);

            double y = z/Math.Tan(crad);
		    double t = Math.Sqrt((z*z)+(y*y));
		    double agrados = Math.Atan(y/z);


		    double arad = agrados / (Math.PI/180.0);

            Console.WriteLine("el valor de y es" + y);
		    Console.WriteLine("el valor de t es" + t);
		    Console.WriteLine("el valor del angulo a es" + arad);
		  */

        }
    }
}
    