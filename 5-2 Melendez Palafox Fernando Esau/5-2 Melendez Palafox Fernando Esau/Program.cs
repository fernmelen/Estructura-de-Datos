using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_Melendez_Palafox_Fernando_Esau
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] primero = { 11, 2, 3, 14, 18, 45, -3, -1, 6, 9 };  //hacemos todos los arreglos precargados
            double[] segundo = { 1, 3, 5, 7, 8, 3, 9, .7071, 16.5664, 12, 0, 10 };
            double[] tercero = { 3, 7, 15, 4 / 3, 155, 100, 15, (3)^2, 5, 2, 3, 2 };
            double[] cuarto = { 8, 19, 7, 3, 15, 23, 34, 27, 89, 101 };
            Orden Usuario1 = new Orden();  //creamos el objeto para ejecutar sus metodos
            Console.WriteLine("Numeros ordenados de primer arreglo");
            Usuario1.QuickSort(primero, 0, 9);Usuario1.Imprimir(primero);  //llamamos a ambos metodos para cada arreglo
            Console.WriteLine("\nNumeros ordenados de segundo arreglo");
            Usuario1.QuickSort(segundo, 0, 11); Usuario1.Imprimir(segundo);
            Console.WriteLine("\nNumeros ordenados de tercer arreglo");
            Usuario1.QuickSort(tercero, 0, 11); Usuario1.Imprimir(tercero);
            Console.WriteLine("\nNumeros ordenados de cuarto arreglo");
            Usuario1.QuickSort(cuarto, 0, 9); Usuario1.Imprimir(cuarto);
            Console.ReadKey();
        }
    }
}
