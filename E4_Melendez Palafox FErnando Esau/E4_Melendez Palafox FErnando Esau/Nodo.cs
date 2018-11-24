using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_Melendez_Palafox_FErnando_Esau
{
    class Nodo
    {
        public string x;
        public Nodo Izquierda, Derecha, Medio;

        public Nodo(string y)
        {
            x = y;
            Izquierda = Derecha = Medio = null;
        }
    }
}
