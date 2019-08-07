using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite el tipo de contrato ");
            int Contrato = int.Parse(Console.ReadLine());
            Console.Write("Digite el valor de su salario ");
            double Salario = double.Parse(Console.ReadLine());
            double cotizacion;
            double eps=0;
            double pension=0;
            double arl=0;
            double deduccion=0;
            double bonificacion = 0;
            int claseriesgo;
            double smmlv = 925148;
            cotizacion = Salario * 0.4;
            if (cotizacion<smmlv )
            {
                cotizacion = smmlv;
            }
            switch(Contrato)
            {
                case 1:
                Console.Write("Digite el numero del 1 al 5 equivalente a la clase de riesgo ");
                claseriesgo = int.Parse(Console.ReadLine());
                pension = cotizacion * 0.16;
                eps = cotizacion * 0.12;
                deduccion = -pension - eps - arl;
                switch (claseriesgo)
                {
                    case 1: arl = cotizacion * 0.00522;
                        break;
                    case 2: arl = cotizacion * 0.01044;
                        break;
                    case 3: arl = cotizacion * 0.02436;
                        break;
                    case 4: arl = cotizacion * 0.04350;
                        break;
                    default: arl = cotizacion * 0.06960;
                        break;
                            
                }
                    break;


                case 2:
                Console.WriteLine("Su contrato no tiene clase de riesgo ");
                pension = cotizacion * 0.04;
                eps = cotizacion * 0.04;
                deduccion = -pension - eps - arl;
                bonificacion = Salario;
                    break;
            }

            double salariorealmensual = Salario - deduccion;
            double salarioanualDB = (Salario - deduccion)*12 + bonificacion;

            Console.WriteLine("Su salario real mensual es: " + salariorealmensual);
            Console.WriteLine("Su salario anual es: " + salarioanualDB);
            Console.WriteLine("Su deduccion es: " + -deduccion);
            Console.WriteLine("Su bonificacion es: " + bonificacion);
            Console.WriteLine("Su eps es: " + -eps);
            Console.WriteLine("Su pension es: " + -pension);
            Console.WriteLine("Su arl es: " + -arl);
        }
    }
}
