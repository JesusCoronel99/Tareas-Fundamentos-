using System;

namespace TareaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta1 = aleatorio.Next(1, 11);
            int carta2 = aleatorio.Next(1, 11);
            Console.WriteLine("Digite su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Su primer carta fue: " + carta1);
            Console.WriteLine("Su segunda carta fue: " + carta2);
            int nuevacarta;
            int total = carta1 + carta2;
            //int total = carta1 + carta2; 
            string respuesta = "s";
            while (respuesta =="s" && total < 21)
            {
                nuevacarta = aleatorio.Next(1, 11);
                Console.WriteLine("Nueva carta: " + nuevacarta);
                total += nuevacarta;
                if (total <= 21)
                {
                    
                    Console.WriteLine("Total: " + total);
                    Console.Write("¿Desea Otra Carta? (s/n): ");
                    respuesta = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Has perdido todo tu dinero :v");
                }
             
            }
            Console.WriteLine("Su total fue: " + total);
            Console.WriteLine("Gracias por participar " + nombre + " Deje el vicio y estudie vago");
        }
    }
}
