using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6__1_Melndez_Palafox_Fernando_Esau
{
    class Pediche
    {
        public void busq() { Console.Write("Escribe el numero que busca: ");int num = int.Parse(Console.ReadLine());
            Busqueda encuentra = new Busqueda();encuentra.Buscar(num);
        }
    }
}
