using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Parcial {

    string[] names;
    double[] data;


    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        int salida = 0 ;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double total = 0;
        for (int i = 0;i < notas.Length; i++)
        {
            total += notas[i];
        }
        double promedio = total / notas.Length;
        for (int i = 0; i< nombres.Length; i++)
        {
            if (notas[i] <= 3.0) salida++;
        }
        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        for(int i =0; i<notas.Length-1; i++)
        {
            for (int j =0; j<notas.Length-1; j++)
            {
                if(notas[j] > notas[j + 1])
                {
                    double tmp = notas[j + 1];
                    notas[j + 1] = notas[j];
                    notas[j] = tmp;

                    string tmp1 = nombres[j + 1];
                    nombres[j + 1] = nombres[j];
                    nombres[j] = tmp1;
                }
            }
        }
       for( int k= 0; k<5; k++)
        {
            salida[k] = nombres[k];
        }



        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] TercerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
       /* int n = 0;
        for (int i = 0; i < nombres.Length; i++)
        {
            if (notas[i] <= 3.0)
            {
                n++;
            }
        }
        string[] Nombresss = new string[n];
        for (int i = 0; i < nombres.Length; i++)
        {
            if (notas[i] <= 3.0)
            {
                Nombresss[i] = nombres[i];
            }
        }
        for ( int j =0; j < Nombresss.Length; j++)
        {
            salida[0] = salida[0] +","+ Nombresss[j];
        }
        */

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> TercerPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------



        for (int i = 0; i < nombres.Length; i++)
        {
            if (notas[i] <= 3.0)
            {
                salida.Add(nombres[i]);
            }
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> CuartoPuntoListas()
    {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        for (int i =0; i < nombres.Length; i++)
        {
            string nombre = nombres[i];
           if (nombre[0] != 'A' && nombre[0] != 'E' && nombre[0] != 'I' && nombre[0] != 'O' && nombre[0] != 'U')
           {
               salida.Add(nombres[i]);
           }
        }

        //- Arriba de esta línea va su código --------
        return salida;
        
    }
}


