using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_Melendez_Palafox_FErnando_Esau
{
    class Arbol
    {
        public void Imprimir()
        {
            Arbol1 arbol = new Arbol1(); // crea un objeto arbol de BinaryTree

            arbol.z = new Nodo("A");
            arbol.z.Izquierda = new Nodo("B");
            arbol.z.Medio = new Nodo("C");
            arbol.z.Derecha = new Nodo("D");
            arbol.z.Izquierda.Izquierda = new Nodo("E");
            arbol.z.Izquierda.Medio = new Nodo("F");
            arbol.z.Izquierda.Derecha = new Nodo("G");
            arbol.z.Derecha.Izquierda = new Nodo("H");
            arbol.z.Derecha.Medio = new Nodo("I");
            arbol.z.Derecha.Derecha = new Nodo("J");
            arbol.z.Izquierda.Izquierda.Izquierda = new Nodo("K");
            arbol.z.Izquierda.Izquierda.Medio = new Nodo("L");
            arbol.z.Izquierda.Izquierda.Derecha = new Nodo("M");
            arbol.z.Izquierda.Derecha.Medio = new Nodo("N");
            arbol.z.Derecha.Izquierda.Medio = new Nodo("O");
            arbol.z.Derecha.Derecha.Izquierda = new Nodo("P");
            arbol.z.Derecha.Derecha.Derecha = new Nodo("Q");
            arbol.z.Izquierda.Derecha.Medio.Izquierda = new Nodo("R");
            arbol.z.Izquierda.Derecha.Medio.Derecha = new Nodo("S");

            Console.WriteLine("Arbol 1");
            Console.WriteLine("Preorden");
            arbol.PrintPreorder();
            Console.WriteLine("\nPostorden");
            arbol.PrintPostorder();
            Console.ReadKey();
        }
    }
}
