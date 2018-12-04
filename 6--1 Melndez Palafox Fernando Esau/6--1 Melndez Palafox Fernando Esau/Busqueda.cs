using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6__1_Melndez_Palafox_Fernando_Esau
{
    class Busqueda
    {
        public void Buscar(int busco)
        {
            int i=0, cont=-1;
            int[] numeros = { 1, 2, 4, 7, 3, 21, 57, 9, 100, 24 };
            bool encontrado = false;
            while (!(encontrado) && i < 10) { if (busco == numeros[i]){ cont = i; encontrado = true; }i++; }
            if (encontrado) { Console.WriteLine("EL numero se encontro en la posicion {0}", cont+1); }
            else if (cont == -1) { Console.WriteLine("Numero no encontrado"); }
            Console.ReadKey();
        }
    }
}
