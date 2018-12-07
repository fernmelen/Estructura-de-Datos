using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6__2_Melendez_Palafox_Fernando_Esau
{
    class Operaciones
    {
        public void Intro()
        {
            Console.Write("Escriba el tamaño de su vector: ");
            int n = int.Parse(Console.ReadLine()); int[] arre = new int[n];
            for (int i = 0; i < arre.Length; i++)
            {
                Console.Write("Escriba el numero para la posicion {0}: ", i + 1);
                arre[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arre);
            Imprimir(arre);
        }
        public void Imprimir(int[] arre)
        {
            Busqueda perro = new Busqueda();
            if (perro.Binaria(arre)) { Console.WriteLine("Encontre un 10 en tus numeros compa"); }
            else { Console.WriteLine("No encontre ningun 10 compa"); }
            Console.WriteLine("Vector oredenado:");
            foreach (var item in arre)
            {
                Console.Write("| {0} |", item);
            }
            Console.ReadKey();
        }
    }
}
