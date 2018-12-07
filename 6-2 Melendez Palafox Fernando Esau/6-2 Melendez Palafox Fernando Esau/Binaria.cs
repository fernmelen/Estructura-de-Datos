using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_Melendez_Palafox_Fernando_Esau
{
    class Binaria
    {
        public void Intro()
        {
            Console.Write("Que numero busca?: ");
            int cochi = int.Parse(Console.ReadLine());
            Buscar(cochi);
        }
        public void Buscar(int objetivo)
        {
            int[] arre = new int[] { 1, 10, 12, 13, 17, 20, 21, 24, 25, 29, 30, 46, 100 };
            int min = 0, max = arre.Length, mitad=0;
            bool encontrado = false;
            while (!encontrado && min <= max)
            {
                mitad = (min + max) / 2;
                if (objetivo == arre[mitad]) { encontrado = true; }
                else if (objetivo < arre[mitad]) { max = mitad - 1; }
                else { min = mitad + 1; }
            }
            Imprimir(encontrado, mitad, arre);
        }
        public void Imprimir(bool perro, int pos,int[]arre)
        {
            if (perro) { Console.WriteLine("Se encontro tu numero en la posicion {0} ", pos + 1); }
            else { Console.WriteLine("No se encontro su numero..."); }
            Console.WriteLine("Vector: ");
            foreach (var item in arre)
            {
                Console.Write("| {0} |", item);
            }
            Console.ReadKey();
        }
        
    }
}
