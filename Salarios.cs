using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite el tipo de contrato ");
            string Contrato = Console.ReadLine();
            Console.Write("Digite el valor de su salario ");
            double Salario = double.Parse(Console.ReadLine());
            double cotizacion;
            double eps;
            double pension;
            double arl=0;
            double deduccion=0;
            double bonificacion = 0;
            int claseriesgo;
            double smmlv = 925148;
            if ((Salario * 0.4) >= smmlv)
            {
                cotizacion = Salario * 0.4;
            }
            else
            {
                cotizacion = smmlv;
            }
            if (Contrato == "independiente")
            {
                Console.Write("Digite el numero del 1 al 5 equivalente a la clase de riesgo ");
                claseriesgo = int.Parse(Console.ReadLine());
                pension = cotizacion * 0.16;
                eps = cotizacion * 0.12;
                switch(claseriesgo)
                {
                    case 1: arl = cotizacion * 0.00522;
                        break;
                    case 2: arl = cotizacion * 0.01044;
                        break;
                    case 3: arl = cotizacion * 0.02436;
                        break;
                    case 4: arl = cotizacion * 0.04350;
                        break;
                    case 5: arl = cotizacion * 0.06960;
                        break;
                }
                deduccion = pension + eps + arl;
            }
            else if (Contrato == "Dependiente")
            {
                Console.WriteLine("Su contrato no tiene clase de riesgo ");
                pension = cotizacion * 0.04;
                eps = cotizacion * 0.04;
                deduccion = pension + eps + arl;
                bonificacion = Salario;
            }

            double salariorealmensual = Salario - deduccion;
            double salarioanualDB = (Salario - deduccion)*12 + bonificacion;

            Console.WriteLine("Su salario real mensual es: " + salariorealmensual);
            Console.WriteLine("Su salario anual es: " + salarioanualDB);
        }
    }
}
