using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_Melendez_Palafox_Fernando_Esau
{
    class Datos
    {
        public void Emepezar()//Metodo para imprimir y llamar metodos de clase Radix
        {
            Console.WriteLine("Primer arreglo:");  
            int[] arre1 = new int[] { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3 };Imprimir(arre1);//Declaracion e impresion del arreglo desordenado
            Console.WriteLine("Arreglo oredenado:");
            Radix a1 = new Radix();a1.RaSort(arre1);Imprimir(arre1);//Instanciar objeto, ordenar con el metodo e imprimir 

            Console.WriteLine("\nSegundo arreglo:");
            int[] arre2 = new int[] { 8, 3, 9, 3, 11, 7, 1, 27, 12 }; Imprimir(arre2);
            Console.WriteLine("Arreglo oredenado:");
            a1.RaSort(arre2); Imprimir(arre2);

            Console.WriteLine("\nTercer arreglo:");
            int[] arre3= new int[] { 10, 40, 36, 5, 24, 2, 5, 8 }; Imprimir(arre3);
            Console.WriteLine("Arreglo oredenado:");
            a1.RaSort(arre3); Imprimir(arre3);

            Console.WriteLine("\nCuarto arreglo:");
            int[] arre4 = new int[] { 55, 42, 0, -3, 0, -1, 2, 4, 7 }; Imprimir(arre4);
            Console.WriteLine("Arreglo oredenado:");
            a1.RaSort(arre4); Imprimir(arre4);

            Console.WriteLine("\nQuinto arreglo:");
            int[] arre5 = new int[] { 25, 108, 1024, 12, 351, 251, 39 }; Imprimir(arre5);
            Console.WriteLine("Arreglo oredenado:");
            a1.RaSort(arre5); Imprimir(arre5);
        }
        public void Imprimir(int[]arre)//Medodo imprimir
        {
            foreach (var item in arre)
            {
                Console.Write("{0}, ", item);
            }
            Console.WriteLine();
        }
    }
}
