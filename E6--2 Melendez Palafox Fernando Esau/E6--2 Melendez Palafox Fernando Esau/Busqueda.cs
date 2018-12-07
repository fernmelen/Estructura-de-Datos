using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6__2_Melendez_Palafox_Fernando_Esau
{
    class Busqueda
    {
        public bool Binaria(int[]arre)
        {
            bool encontre = false;
            int min = 0, max = arre.Length, mitad;
            while (!encontre && min <= max)
            {
                mitad = (min + max) / 2;
                if (arre[mitad] == 10) { encontre = true; }
                else if (arre[mitad] > 10) { max = mitad - 1; }
                else { max=min=mitad+1;}
            }
            return encontre;
        }
    }
}
