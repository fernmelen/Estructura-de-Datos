using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4__Melendez_PAlafox_Fernando_Esau
{
    class Arbol
    {
        public Nodo raiz;
        public Arbol() { raiz = null; }
        public Nodo ImprimirRaiz() { return raiz; }
        public void Insertar(int id)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = id;
            if (raiz == null) { raiz = nuevo; }
            else
            {
                Nodo actual = raiz;
                Nodo padre;
                while (true)
                {
                    padre = actual;
                    if (id < raiz.dato)
                    {
                        actual = actual.izq;
                        if (actual==null)
                        { padre.izq = nuevo; return; }
                    }
                    else
                    {
                        actual = actual.der;
                        if (actual == null) { padre.der = nuevo; return; }
                    }
                }
            }
        }
        public void Preorden(Nodo raiz)
        {
            List<char> lista = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            if (raiz != null)
            {

                if (raiz != null)
                {
                    if (raiz.dato == -2) { raiz.dato = 5; }
                    Console.Write(lista[(raiz.dato)] + " ");
                    Preorden(raiz.izq);
                    Preorden(raiz.der);
                }
            }
        }
        public void Postorden(Nodo raiz)
        {
            List<char> lista = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            if(raiz != null)
            {
                if (raiz.dato == -2) { raiz.dato = 5; }
                Postorden(raiz.izq);
                Postorden(raiz.der);
                Console.Write(lista[(raiz.dato)] + " ");
            }
        }
    }
}
