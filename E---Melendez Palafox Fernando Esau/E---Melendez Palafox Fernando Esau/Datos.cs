using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E___Melendez_Palafox_Fernando_Esau
{
    class Datos
    {
        public void Capturar()
        {
            Console.Write("Escribir la cantidad de numeros que desea ingresar: ");
            int cant = int.Parse(Console.ReadLine());
            int[] arreglo = new int[cant];
            for (int i = 0; i < cant; i++)
            {
                Console.Write("Escriba el numero de la posicion {0}: ", i + 1);
                arreglo[i] = int.Parse(Console.ReadLine());
            }
            Shell User = new Shell();User.ShellSort(arreglo);
            Console.WriteLine("Numeros ordenados de mayyor a menor: ");
            foreach (var item in arreglo)
            {
                Console.Write("| " + item + " |");
            }
            Console.ReadKey();
        }
    }
}
