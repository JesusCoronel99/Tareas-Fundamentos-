using System;

namespace DadosCasa01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int vidas = 3,turnos = 0, puntos = 0;
            Console.WriteLine("Vidas Iniciales: " + vidas);
            while (true)
            {
                turnos++;
                int dado = aleatorio.Next(1, 7);
                Console.WriteLine("Dado: " + dado);
                puntos += dado;
                Console.WriteLine("Puntos: " + puntos);
                if (turnos %2 == 0)
                {
                    Console.WriteLine("Has Perdido Una Vida");
                    vidas -= 1;
                    Console.WriteLine("Vidas: " + vidas);
                }
                if (turnos %3 == 0)
                {
                    int dado1 = aleatorio.Next(1, 7);
                    Console.WriteLine("Nuevo Dado: " + dado1);
                    Console.WriteLine("Nuevo Dado: " + dado);         
                    if (dado1 == dado)
                    {
                        Console.WriteLine("Has Ganado Una Vida");
                        vidas += 1;
                        Console.WriteLine("Vidas: " + vidas);
                    }
                }
                if (vidas == 0)
                {
                    Console.WriteLine("GAME OVER");
                    break;
                }
                Console.WriteLine("Desea Continuar (s/n) ");
                if (Console.ReadLine() != "s") break;
            }
            Console.WriteLine("Puntos: " + puntos);
            Console.WriteLine("Gracias Por Jugar");

        }
    }
}
