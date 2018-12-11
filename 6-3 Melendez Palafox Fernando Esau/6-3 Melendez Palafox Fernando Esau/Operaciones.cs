using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_Melendez_Palafox_Fernando_Esau
{
    class Operaciones
    {
        public void Ladrar()
        {
            string[] Arreglo = { "70", "56", "42", "33", "93", "55", "80", "13", "10", "19", "21" };//Iniciamos un arreglo precargado
            Hash usuario = new Hash(Arreglo.Length);//Objeto para operaciones
            usuario.Asignar(Arreglo, usuario.arre);//Mandamos el arreglo actual y el global para la asignacion de posiciones
            usuario.Imprimir(Arreglo);//Imprime el contenido del arreglo ya ordenado por clave
            Console.Write("\nQue numero desea traer al frente de nuestro arreglo? ");
            string busca = Console.ReadLine();//captura lo que el usuario busca
            usuario.Buscar(busca);//manda a buscar al metodo el dato
            if (busca == null) { Console.Write("No se encontro el elemento..."); }//cuando el metodo no encontro dato y regresa vacio se mustra este mensaje
            Console.ReadKey();//Detener consola
        }
    }
}
