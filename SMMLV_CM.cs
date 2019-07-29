using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double salariominimo = 925148;
            Console.Write("Ingrese el salario que recibe: ");
            double smmlv = double.Parse(Console.ReadLine());

            if (smmlv < salariominimo * 2)
            {
                Console.WriteLine("Usted esta en tarifa A, Su cuota moderadora es de $3.200");
            }
            else if (salariominimo * 2 <= smmlv && smmlv < salariominimo * 5)
            {
                Console.WriteLine("Usted esta en tarifa B, Su cuota moderadora es de $12.700");
            }
            else
            {
                Console.WriteLine("Usted esta en tarifa C, Su cuota moderadora es de $35.500");
            }
        }
    }
}
