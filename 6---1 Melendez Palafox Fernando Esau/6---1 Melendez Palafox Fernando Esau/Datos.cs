using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___1_Melendez_Palafox_Fernando_Esau
{
    class Datos
    {
        public void Capturar()
        {
            int[] vect = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Escriba un entero para la posicion {0}/10: ", i + 1);
                vect[i] = int.Parse(Console.ReadLine());
            }
            Busco usuario1 = new Busco();usuario1.Buscar(vect);
        }
    }
}
