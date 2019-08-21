using System;

namespace EjercicioClase20agosto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int a = aleatorio.Next(0, 10);
            int b = aleatorio.Next(0, 10);
            int contador = 1;
            Console.WriteLine("A: " + a + " B: " + b);
            int sumacorrecta = a + b;
            Console.Write("Ingrese la suma entre a y b: ");
            int suma = int.Parse(Console.ReadLine());

            while (sumacorrecta != suma)
            {
                a = aleatorio.Next(0, 10);
                b = aleatorio.Next(0, 10);
                Console.WriteLine("A: " + a + " B: " + b);
                Console.WriteLine("Incorrecto, trate de nuevo");
                Console.WriteLine("Ingrese la suma entre a y b: ");
                sumacorrecta = a + b;
                suma = int.Parse(Console.ReadLine());
                contador++;
                if (contador == 3 && sumacorrecta != suma)
                {
                    Console.WriteLine("Demasiados Intentos");
                    break;
                }
                else if (contador <3 && sumacorrecta == suma)
                {
                    Console.WriteLine("Acceso Permitido");
                    break;
                }
            }
        }
    }
}
