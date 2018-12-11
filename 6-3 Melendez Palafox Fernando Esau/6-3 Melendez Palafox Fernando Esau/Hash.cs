using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_Melendez_Palafox_Fernando_Esau
{
    class Hash
    {
        public string[] arre;  //Variables locales que se usan para todo el ordenamiento
        int tamaño;
        public Hash(int tamano)//Constructor para las variables anteriores
        {
            tamaño = tamano;
            arre = new string[tamano];
            for (int i = 0; i < arre.Length; i++)//Llenar el arreglo con -1 para poder usar las condiciones mas adelante
            {
                arre[i] = "-1";
            }
        }
        public void Asignar(string[] cadena, string[] Arre)//Metodo de ordenamiento
        {
            for (int i = 0; i < cadena.Length; i++)//cursor de posicion del arreglo
            {
                string temp = cadena[i];//Temporal para operaciones que toma valor del arreglo en posicion actual
                int indice = int.Parse(temp) % 7;//Determirar el indice donde deve ubicarse el numero dependiendo su clave con residuo con 7
                Console.WriteLine("El indice {0} para el elemento {1}", indice, temp);
                while (Arre[indice]!="-1")//Cuando la clave coincide con una anterior se mueve el indice hacia la siguiente pos, a esto se le llama "Colision"
                {
                    indice++;
                    Console.WriteLine("Ocurrio una colicion en el indice {0}, se cambio al indice {1}", indice - 1, indice);
                    indice %= tamaño;//Se determina el modulo del indice o clave con el tamaño del arreglo para encontrarle posicion
                }
                Arre[indice] = temp;//guardamos el dato en la posicion previamente determinada
            }
        }
        public void Imprimir(string [] arre)//Imprime el contenido del arreglo con su posicion encima
        {
            Console.WriteLine("Orden del arreglo:");
            for (int i = 0; i < arre.Length; i++)
            {
                Console.Write("|  {0} |",i);
            }
            Console.WriteLine();
            for (int i = 0; i < arre.Length; i++)
            {
                Console.Write("| {0} |", arre[i]);
            }
        }
        public string Buscar(string busco)//Metodo para encontrar un numero segun su clave
        {
            int indice = int.Parse(busco) % 7;//Se determina la clave segun el dato a buscar
            int cont = 0;//contador 
            while (arre[indice] != "-1")//mientras el contenido del arreglo global no este vacio se sigue buscando
            {
                if (arre[indice] == busco)//Entramos cuando se encuentra el dato en la posicion alctual
                {
                    Console.WriteLine("Se encontro el elemento {0} en la posicion {1}", busco, indice);
                    return arre[indice];//regresa el valor de la clave o posicion
                }
                indice++;//al no encontrar se aumenta el indice a la siguiente posicion
                indice %= tamaño;//se determina la posicion por medio de modulo del tamaño del arreglo global
                cont++;//aumenta el contador para llevar control del ciclo
                if (cont > arre.Length) { break; }// cuando el contador supera las busquedas necesaria sale del while
            }
            return null;//reglesa vacio cuando no se encuentra el dato
        }
    }
}
