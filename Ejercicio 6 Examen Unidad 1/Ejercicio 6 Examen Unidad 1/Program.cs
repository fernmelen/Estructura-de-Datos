using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_Examen_Unidad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int max = 0; int pos1 = 0; int j = 1;
                Console.Write("Escriba el numero de intentos que necesota: ");
                int x = int.Parse(Console.ReadLine()); string[] Palabra = new string[x];
                for (int i = 0; i < x; i++)
                {
                    Console.Write("Palabra {0}/{1}: ", i + 1, x);
                    Palabra[i] = Console.ReadLine();
                    int c = 0;
                    foreach (char y in Palabra[i]) { c++; }
                    if (c > max && pos1 < i) { max = c; pos1 = i; j++; }
                }
                if (j == x) { pos1 = 0; Console.WriteLine(pos1); }
                else Console.WriteLine("La primera vez que la palabra sucesora fue mas alta es: {0} \nEn la posicion: {1}", Palabra[pos1], pos1 + 1);
                Console.ReadKey();
            }catch(Exception e) { Console.Write(e.Message);Console.ReadKey(); }
        }
    }
}
