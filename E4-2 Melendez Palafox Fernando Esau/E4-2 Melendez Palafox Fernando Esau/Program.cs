using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_2_Melendez_Palafox_Fernando_Esau
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol A1 = new Arbol();//Se crea un objeto de tipo Tree llamado tree
            A1.Imprimir1();//se llama al metodo PrintTreeA de la clase Tree
            Console.Clear();//Se limpia la consola
            A1.Imprimir2();//se llama al metodo PrintTreeB de la clase Tree
            Console.Clear();//Se limpia la consola
            A1.Imprimir3();//se llama al metodo PrintTreeC de la clase Tree
        }
    }
}
