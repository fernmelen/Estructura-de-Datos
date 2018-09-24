using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Examen_Unidad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int Max=0, Min=0;
                Console.WriteLine("Escriba el numero de intentos");
                int i = int.Parse(Console.ReadLine());
                for (int j=0;j<i;j++)
                {
                    Console.Write("Escriba el numero: ");
                    int x = int.Parse(Console.ReadLine());
                    if (j == 0) { Max = x;Min = x; }
                    if (j != 0) { if (x < Min) { Min = x; }if (x > Max) { Max = x; } }
                }
                Console.WriteLine("Valor Maximo ingresado: {0}\nValor Minimo ingresado: {1}", Max, Min);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
    }
}
