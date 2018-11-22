using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_1_Melendez_Palafox_Fernando_Esau
{
    class Program
    {
        static void Main(string[] args)
        {
            int temporal;     //temporal necesaria para almacenar el numero menor
            int[] wea = new int[4] { 3, 5, 2, 1 };  //arreglo precargado de numeros desordenados
            Console.WriteLine("Elementos desordenados: ");   //Titulo
            foreach (int h in wea)
            {
                Console.Write("| {0} |", h);    //muestra cada elemento del arreglo
            }
            for (int i = 0; i < wea.Length; i++)  //avanza onforme el tamaño del arreglo
            {
                for (int j = 0; j < wea.Length-1; j++)  //iteracion para comparar y tomar al contador como indice
                {
                    if (wea[j] > wea[j+1])  //condicion con comparacion de el elemento actual con el elemento siguiente segun el contador
                    {
                        temporal = wea[j+1];  //igualar el elementomenor a la temporal
                        wea[j+1] = wea[j];    //igualacion de el elemento mas grande en las dos posiciones
                        wea[j] = temporal;    //igualar la temporal a la posicion actual para dejar ordenado
                    }
                }
            }
            Console.WriteLine("\nElementos ordenados: ");    //Titulo
            foreach (int h in wea)
            {
                Console.Write("| {0} |", h);  //escribe todos los elementos del arreglo ya ordenado
            }Console.ReadKey();
        }
    }
}
