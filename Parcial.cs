using System;
using System.Collections.Generic;
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

        int estudiantesMayora3 = 0, indice = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] <= 3.0)
            {
                estudiantesMayora3++;
                indice = i;             
            }
        }
        salida = estudiantesMayora3;
        Console.WriteLine("Los estudiantes con nota menor o igual a 3 son: " + salida);



        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
      
        for (int i = 0; i < notas.Length-1; i++ )
        {
            for (int j = 0; j < notas.Length - 1; j++)
            { 
                if (notas[j] > notas[j + 1])
                { 
                    double temp = notas[j+1];
                    notas[j + 1] = notas[j];
                    notas[j] = temp;

                    string temp2 = nombres[j + 1];
                    nombres[j + 1] = nombres[j];
                    nombres[j] = temp2;
                }
            }
        }
        for(int k = 0; k<5; k++)
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

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] <= 3.0)
            {
                salida.Add(nombres[i]);
            }
        }



        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> CuartoPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------  
        
        for ( int i = 0; i<nombres.Length; i++)
        {
            if (nombres[i][0] == 'A' || nombres[i][0] == 'E'|| nombres[i][0] == 'I'|| nombres[i][0] == 'O' || nombres[i][0] == 'U')
            {
                salida.Add(nombres[i]);             
            }
        }



        //- Arriba de esta línea va su código --------
        return salida;
    }
}


