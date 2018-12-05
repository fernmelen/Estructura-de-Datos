using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E__5_Melendez_Palafox_Fernando_Esau
{
    class Datos
    {
        public void Genrar()
        {
            Random R1 = new Random();
            int[] numeros = new int[80];
            for (int i = 0; i < 80; i++)
            {
                int temp = R1.Next(0, 100);
                if (numeros.Contains(temp)) { i = i - 1; }
                else { numeros[i] = temp; }
            }
            Console.WriteLine("Numeros desordenados: ");
            foreach (var item in numeros)
            {
                Console.Write("| " + item + " |");
            }
            Radix user = new Radix();user.RaSort(numeros);
            Console.WriteLine("\nNumeros ordenados");
            foreach (var item in numeros)
            {
                Console.Write("| " + item + " |");
            }

        }
    }
}
