using System;

namespace TareaDado
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int total = 0, contador = 0, condicion = 0; 
            while (true)
            {
                contador++;
                int dado = aleatorio.Next(1, 13);
                Console.WriteLine("Dado: " + dado);
                if (dado == 10) condicion += 1;
                if (contador <= 3)
                {
                    if (dado ==12 && condicion==1)
                    {
                        Console.WriteLine("Ha Ganado");
                        Console.WriteLine("Total: " + total);
                        break;
                    }
                    total += dado;
                    Console.WriteLine("Total: " + total);
                    Console.WriteLine("Desea Continuar (s/n)");
                    if (Console.ReadLine() != "s") break;
                }
                else if (dado %2 == 0)
                {
                    total += dado;
                    Console.WriteLine("Total: " + total);
                    if (dado == 12 && condicion == 1)
                    {
                        Console.WriteLine("Ha Ganado");
                        Console.WriteLine("Total: " + total);
                        break;
                    }
                    if (total >= 100) Console.WriteLine("Ha Ganado");
                    Console.WriteLine("Desea Continuar (s/n)");
                    if (Console.ReadLine() != "s") break;
                }
                else
                {
                    total += dado;
                    Console.WriteLine("Total: " + total);
                    Console.WriteLine("Ha Sacado Numero Impar, Queda ELIMINADO");
                    break;
                }
            }
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Fin del Juego");
        }
    }
}
