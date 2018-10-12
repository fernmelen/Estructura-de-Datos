using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EC3_1_Melendez_Palafox_Fernando_Esau
{
    class Program
    {
        static void Main(string[] args)
        {
            var Pila = new Stack();
            Pila.Push("Fernando");
            Pila.Push("Kevin");
            Pila.Push("Isaac");
            Pila.Push("Jesus");
            Pila.Push(1109);
            Pila.Push(17211539);
            Console.WriteLine("Lista de contenido");
            foreach (var item in Pila)//foreach para imprimir los datos guardados en la pila
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("La pila contienene a Fernando");
            bool a = Pila.Contains("Fernando"); 
            Console.WriteLine(a);  //indica si ese elemento esta en la pila
            Console.WriteLine(Pila.Pop().GetType());  //indica el tipo de los elementos en la pila
            Console.WriteLine(Pila.Contains(1109)); //indica en bool si el elemento indicado aparece 
            Console.WriteLine(Pila.ToString()); //Escribe el objeto actual en string
            Console.WriteLine(Pila.ToArray());  //Copia cada elemento de la pila a una matriz
            Console.WriteLine(Pila.GetEnumerator());  //permite usar enumeradores para recorrer la pila
            Console.ReadKey();
        }
    }
}
