using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_Melendez_Palafox_FErnando_Esau
{
    class Arbol1
    {
        public Nodo z;
        public Arbol1()
        {
            z = null;
        }
        public void PostOrden(Nodo nodo)
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izquierda);

            PostOrden(nodo.Medio);


            PostOrden(nodo.Derecha);


            Console.Write(nodo.x + " ");
        }
        public void PreOrden(Nodo node)
        {
            if (node == null)
                return;

            Console.Write(node.x + " ");

            PreOrden(node.Izquierda);

            PreOrden(node.Medio);

            PreOrden(node.Derecha);
        }
        public void PrintPostorder() { PostOrden(z); }
        public void PrintPreorder() { PreOrden(z); }
    }
}

