using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___1_Melendez_Palafox_Fernando_Esau
{
    class Busco
    {
        public void Buscar(int[] vector)
        {
            int numero = 7, i = 0, cont = -1;
            bool busqueda = false;
            while (!(busqueda) && i < 10)
            {
                if (numero == vector[i])
                {
                    busqueda = true;cont = i;
                }i++;
            }Console.Clear();
            if (busqueda) { Console.WriteLine("El numero 7 se encontraba en la posicion {0}", cont+1); }
            else if (cont == -1) { Console.WriteLine("No encontre ningun numero 7 en la secuencia"); }
            Console.ReadKey();
        }
    }
}
