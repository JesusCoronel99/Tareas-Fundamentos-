using System;

namespace Bool
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese numero de votos por partido, votos en blanco, anulados, niumero de votos y el porcetnaje mayor de edad: ");
            int votos1 = int.Parse(Console.ReadLine());
            int votos2 = int.Parse(Console.ReadLine());
            int vblanco = int.Parse(Console.ReadLine());
            int vanulado = int.Parse(Console.ReadLine());
            int poblacion = int.Parse(Console.ReadLine());
            double porcentaje = double.Parse(Console.ReadLine());

            double mayores = poblacion * (porcentaje / 100);

            int votantes = votos1 + votos2 + vblanco + vanulado;

            bool a = votantes > poblacion;
            bool b = (votos1 - votos2) < votantes * 0.1;
            bool c = votantes < (poblacion * 0.3);

            Console.WriteLine("Votos del partido 1" + votos1);
            Console.WriteLine("Votos del partido 2" + votos2);
            Console.WriteLine("Votos en blanco " + vblanco);
            Console.WriteLine("Votos anulados " + vanulado);
            Console.WriteLine("Votos totales " + votantes);
            Console.WriteLine("Poblacion de todas la edades " + poblacion);
            Console.WriteLine("Poblacion Mayores de edad " + mayores);
            Console.WriteLine("Mayores de edad " + porcentaje);

            if ((a||b) && c)
            {
                Console.WriteLine("Se repiten las elecciones");
            }
            else if (votos1 < votos2)
            {
                Console.WriteLine("El ganador es el partido 2");
            }
            else
            {
                Console.WriteLine("Elganador es el partido 1");
            }
        }
    }
}
