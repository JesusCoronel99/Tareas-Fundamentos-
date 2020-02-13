using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, total = dado1 + dado2, pares = 0, vecesjugadas = 0,numpares =3;
            double masde6 = 0;
            double porcentaje = 0;
            Console.WriteLine("¿Desea Empezar?");
            string continuar = Console.ReadLine();

            while (continuar == "s" && dado1 + dado2 !=2)
            {
                dado1 = aleatorio.Next(1, 11);
                dado2 = aleatorio.Next(1, 11);
                Console.WriteLine("Dado1 = " + dado1 + " Dado2 = " + dado2);
                total += dado1 + dado2;
                vecesjugadas++;
                porcentaje = (masde6 / vecesjugadas) * 100;
                if (dado1 == 1 && dado2 == 1)
                {
                    total = 0;
                    Console.WriteLine("Eliminado, Ambos numeros son 1");
                    continuar = "n";
                }
                if (dado1 + dado2 >= 6)
                {
                    masde6++;
                    Console.WriteLine("Mas de 6");
                }
                if (dado1 == dado2)
                {
                    pares++;
                    numpares -= 1;
                    Console.Write("Vaya! Has asacado un par, solo " + numpares + " más para ganar");
                }
                if (continuar == "s" && total < 100)
                {                   
                    Console.WriteLine("Total: " + total);
                    Console.WriteLine("Desea Continuar (s/n)?");
                    continuar = Console.ReadLine();
                    
                }
                else
                {
                    Console.WriteLine("Gracias por jugar");
                    Console.WriteLine("Su total fue: " + total);
                }
                if (total >= 100 || pares == 3)
                {
                    Console.WriteLine("Felicidades! Ha ganado");                    
                    Console.WriteLine("Su porcentaje de turnos fue:" + porcentaje);
                    continuar = "n";
                }
            }                    
        }
    }
}
