using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_Examen_Unidad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] S = new string[6];
                for(int i = 0; i < 6; i++) { Console.Write("\nEscriba una palabra y presione <enter> {0}/6: ", i + 1);S[i]= Console.ReadLine(); }
                Console.WriteLine("El inverso de la sucecion que ingreso es: ");
                for (int i = 5; i >= 0; i--) { Console.Write(" "+S[i]); }
                Console.ReadKey();
            }catch(Exception e) { Console.Write(e.Message);Console.ReadKey(); }
        }
    }
}
