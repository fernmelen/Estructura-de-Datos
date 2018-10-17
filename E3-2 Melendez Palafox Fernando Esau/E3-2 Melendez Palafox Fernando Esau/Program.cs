using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_2_Melendez_Palafox_Fernando_Esau
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue MiCola = new Queue();
            Console.WriteLine("Esto metere a mi cola:");
            MiCola.Enqueue("Vaselina");     //Ingresa contenido a la cola
            MiCola.Enqueue("Pepino");      //a diferencia de la pila, este va hasta el final de la cola
            MiCola.Enqueue(200);  
            MiCola.Enqueue("Doctor");
            MiCola.Enqueue("Enfermero");
            foreach (var item in MiCola)   //Muestra el contenido en la cola
            { Console.WriteLine(item); }
            MiCola.Dequeue();             //Elimina el primer elemento ingresado a la cola a diferencia de la pila
            Console.WriteLine("Elimine vaselina...");
            Console.WriteLine("El primer elemento en la cola con peek es: {0}", MiCola.Peek());
            //El peek muestra el primer elemento de la cola sin eliminarlo
            Console.WriteLine("Mi cola contiene un pepino: {0}", MiCola.Contains("Pepino"));
            //La propiedad contains devuelve en formato bool si la cola contiene lo especificado
            Console.WriteLine("A mi cola le cupieron {0} elementos...", MiCola.Count);
            //El count por su traduccion cuenta los elementos dentro de la cola
            Console.WriteLine("...lo siguiente: ");
            foreach (var item in MiCola)   //Muestra el contenido que sigue en la cola
            { Console.WriteLine(item); }
            Console.ReadKey();
        }
    }
}
