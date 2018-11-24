using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4__Melendez_PAlafox_Fernando_Esau
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol arbol1 = new Arbol();
            arbol1.Insertar(0);
            arbol1.Insertar(1);
            arbol1.Insertar(2);
            arbol1.Insertar(3);
            arbol1.Insertar(4);
            arbol1.Insertar(-2);
            arbol1.Insertar(6);
            arbol1.Insertar(7);
            Console.WriteLine("Arbol 2");
            Console.WriteLine("Preorden: ");
            arbol1.Preorden(arbol1.ImprimirRaiz());
            Console.WriteLine();
            Console.WriteLine("Postorden: ");
            arbol1.Postorden(arbol1.ImprimirRaiz());
            Console.ReadKey();
        }
    }
}
