using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_Melendez_Palafox_Fernando_Esau
{
    class Datos
    {
        public void capturar()
        {
            bool ciclo = false;
            Console.Write("Escriba La cantidad de numeros a ingresar: ");
            int cant = int.Parse(Console.ReadLine()); int[] numeros = new int[cant];
            do
            {
                try
                {
                    for (int i = 0; i < cant; i++)
                    {
                        Console.Clear();
                        Console.Write("Escriba solo numeros entre 0 y 2: {0}/{1} ", i + 1, cant);
                        int temp = int.Parse(Console.ReadLine());
                        if (temp >= 0 && temp <= 2) { numeros[i] = temp; }
                        else { throw new FormatException(); }
                    }
                    ciclo = true;
                }
                catch (FormatException) { Console.Write("Ingrese Solamente los numeros 0, 1, o 2");Console.ReadKey(); ciclo = false; }
            } while (ciclo == false);
            Ordenar usuario = new Ordenar();usuario.ordenar(numeros);usuario.Imprimir(numeros);
        }
    }
}
