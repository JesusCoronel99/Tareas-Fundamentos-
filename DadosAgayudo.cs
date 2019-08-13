using System;

namespace Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, total = dado1 + dado2, pares = 0, vecesjugadas = 0;
            double masde6 = 0; 
            double porcentaje = 0;
            string continuar = "si";
            

            while (continuar == "si" && (dado1 !=1 && dado2 !=1) )
            {
                dado1 = aleatorio.Next(1, 7);
                dado2 = aleatorio.Next(1, 7);
                Console.WriteLine("Dado1: " + dado1 +" Dado2: " + dado2);
                total += dado1+dado2;
                vecesjugadas++;
                porcentaje = (masde6 / vecesjugadas) * 100;
                if (dado1 == 1 && dado2 == 1)
                {
                    total = 0;
                    Console.WriteLine("Eliminado");
                }
                else if (continuar == "si" && total <= 100)
                {
                   
                    vecesjugadas += 1;
                    Console.WriteLine("Total: " + total);
                    Console.WriteLine("¿Desea Continuar?: " + continuar);
                    continuar = Console.ReadLine();
                }
                else if (dado1 == dado2) 
                {
                    pares++;
                    Console.WriteLine("Pares: " + pares);
                }
                else if ((dado1 + dado2) > 6)
                {
                    masde6++;
                }
                else if (total>=100 && pares ==3)
                {

                    Console.WriteLine("Felicitaciones, Ha ganado");
                }

            }

            Console.WriteLine("Su total fue: " + total);
            Console.WriteLine("Su Porcentaje fue: " + porcentaje);
            Console.WriteLine("Gracias Por jugar");

        }
    }
}
