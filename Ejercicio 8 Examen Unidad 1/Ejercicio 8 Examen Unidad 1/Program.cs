using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8_Examen_Unidad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cycle = true;
            do
            {
                try
                {
                    Console.Write("Escriba un palindromo: ");
                    int x = int.Parse(Console.ReadLine());
                    if (x > 99999) { throw new FormatException("Fuera del limite de digitos, se espera 5 digitos"); }
                    if (x.ToString()[0] == x.ToString()[4]&& x.ToString()[1]== x.ToString()[3])
                    { Console.WriteLine("Se ha detectado un palindromo: {0}", x);cycle = false; Console.ReadKey(); }
                    else { Console.WriteLine("El numero ingresado no es palindromo... \nPresione <enter> para reintentar.");Console.ReadKey(); }
                }
                catch (Exception e) { Console.Write(e.Message); cycle = true; }
            }
            while (cycle == true);
        }
    }
}
