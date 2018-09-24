using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_Examen_Unidad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            int min = 0;
            for(int i = 0; i < 3; i++) { Console.Clear();Console.Write("Escriba un numero {0}/3: ", i + 1);
                int x = int.Parse(Console.ReadLine());
                    if (i == 0) { min = x; }
                if (x < min) { min = x; }
            }Console.WriteLine("El valor minimo ingresado es {0}", min); Console.ReadKey();
            }catch(Exception e) { Console.Write(e.Message);Console.ReadKey(); }
        }
    }
}
