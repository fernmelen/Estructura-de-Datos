using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7_Examen_Unidad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();
            Console.Write("Indique una cantidad de numeros: ");
            int x = int.Parse(Console.ReadLine());
            int[] y = new int[x];
            Console.WriteLine("-Numeros aleatorios desordenados-");
            for(int i = 0; i < x; i++) { y[i] = R.Next(1, 100); Console.Write("| {0} |", y[i]); }
            Array.Sort(y); Console.WriteLine("\n-Numeros aleatorios ordenados-");
            for (int i = 0; i < x; i++) { Console.Write("| {0} |", y[i]); }
            Console.ReadKey();
        }
    }
}
