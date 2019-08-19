using System;

namespace TareaDados02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int vidas = 3, turnos = 0, puntos = 0, contadoresError = 0, contadoresVidas = 0, contadoresSeis = 0;            
            while (true)
            {
                turnos++;
                int dado = aleatorio.Next(1, 7);
                Console.WriteLine("Dado: " + dado);
                puntos += dado;
                
                if (dado==1) contadoresError += 1;
                if (dado == 6) contadoresVidas += 1;
                if (contadoresError==2) 
                {
                    vidas -= 1;
                    puntos -= 10;
                    
                    contadoresError = 0;
                }
                if (3> vidas && vidas >= 1)
                {
                    if (contadoresVidas == 2)
                    {
                        contadoresSeis++;
                        contadoresVidas = 0;
                    }
                    else contadoresSeis = 0;
                  if (contadoresSeis == 1)
                  {
                        vidas += 1;                       
                        contadoresSeis = 0;
                    }
                }
                if (vidas == 0)
                {
                    Console.WriteLine("GAME OVER");
                    break;
                }
                Console.WriteLine("Vidas: " + vidas);
                Console.WriteLine("Puntos: " + puntos);
                Console.WriteLine("Desea Continuar (s/n) ");
                if (Console.ReadLine() != "s") break;
            }
            Console.WriteLine("Puntos: " + puntos);
            Console.WriteLine("Gracias Por Jugar");

        }
    }
}
        