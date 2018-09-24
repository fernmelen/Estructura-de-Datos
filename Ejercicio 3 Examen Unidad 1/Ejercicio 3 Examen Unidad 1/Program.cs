using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Examen_Unidad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Max = 0; int Pos = 0;
            Console.Write("Escriba la cantidad de intentos que necesita: ");
            int x = int.Parse(Console.ReadLine());
            double[] Y = new double[x];
            for (int i = 0; i < x; i++)
            {
                Console.Clear(); Console.Write("Numero {0}/{1}: ", i + 1, x);
                Y[i] = Single.Parse(Console.ReadLine());
                if (Y[i] >= Max) { Max = Y[i]; Pos = i + 1; }
            }
            Console.WriteLine("El numero Mayor ingresado es: {0} \nY se encuentra en su ultima posicion: {1}", Max, Pos);
            Console.ReadKey();
        }
    }
}
