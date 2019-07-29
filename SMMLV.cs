using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            double salariominimo = 925148;
            Console.Write("Ingrese el salario que recibe ");
            double smmlv = double.Parse(Console.ReadLine());

            if (smmlv < salariominimo * 2)
            {
                Console.WriteLine("Su tarifa correspondiente es la A");
            }
            else if (salariominimo * 2 <= smmlv && smmlv < salariominimo * 4)
            {
                Console.WriteLine("Su tarifa correspondiente es la B");
            }
            else
            {
                Console.WriteLine("Su tarifa correspondiente es la C");
            }
        }
    }
}
