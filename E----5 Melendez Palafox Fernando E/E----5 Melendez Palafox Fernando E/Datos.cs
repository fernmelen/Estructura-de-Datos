using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E____5_Melendez_Palafox_Fernando_E
{
    class Datos
    {
        public void Comparar()
        {
            int i = 0;
            string ABC = "aabcdefghijklmnopqrstuvwxyz";
            int[] numeros = new int[180];
            char [] Letras = new char[180];
            string FraseRara = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce varius, augue vitae tincidunt viverra, sem felis bibendum nisl, id cursus diam leo sit amet urna. Duis ac massa est.";
            
            foreach (char item in FraseRara.ToUpper())
            {
                Letras[i] = item;
                i++;
            }
            Llenar(numeros, Letras, i);
            Quick User = new Quick();User.QuickSort(numeros, 0, 179); User.QuickSort(numeros, 0, 179); User.QuickSort(numeros, 0, 179);User.QuickSort(numeros, 0, 179);
            Console.Write("Numeros ordenados: ");
            foreach (var item in numeros)
            {
                if (item != 0) { Console.Write("| " + item + " |"); }
                
            }
            Console.WriteLine("\nLetras ordenadas:");
            foreach (var item in numeros)
            {
                if (item != 0) { Console.Write("| " + ABC[item] + " |"); }

            }
            Console.ReadKey();
        }
        public void Llenar(int []numeros,char[]Letras,int i)
        {
            for (int j = 0; j < Letras.Length; j++)
            {
                switch (Letras[j])
                {
                    case 'A':
                        numeros[j] = 1;
                        break;
                    case 'B':
                        numeros[j] = 2;
                        break;
                    case 'C':
                        numeros[j] = 3;
                        break;
                    case 'D':
                        numeros[j] = 4;
                        break;
                    case 'E':
                        numeros[j] = 5;
                        break;
                    case 'F':
                        numeros[j] = 6;
                        break;
                    case 'G':
                        numeros[j] = 7;
                        break;
                    case 'H':
                        numeros[j] = 8;
                        break;
                    case 'I':
                        numeros[j] = 9;
                        break;
                    case 'j':
                        numeros[j] = 10;
                        break;
                    case 'K':
                        numeros[j] = 11;
                        break;
                    case 'L':
                        numeros[j] = 12;
                        break;
                    case 'M':
                        numeros[j] = 13;
                        break;
                    case 'N':
                        numeros[j] = 14;
                        break;
                    case 'O':
                        numeros[j] = 15;
                        break;
                    case 'P':
                        numeros[j] = 16;
                        break;
                    case 'Q':
                        numeros[j] = 17;
                        break;
                    case 'R':
                        numeros[j] = 18;
                        break;
                    case 'S':
                        numeros[j] = 19;
                        break;
                    case 'T':
                        numeros[j] = 20;
                        break;
                    case 'U':
                        numeros[j] = 21;
                        break;
                    case 'V':
                        numeros[j] = 22;
                        break;
                    case 'W':
                        numeros[j] = 23;
                        break;
                    case 'X':
                        numeros[j] = 25;
                        break;
                    case 'Y':
                        numeros[j] = 26;
                        break;
                    case 'Z':
                        numeros[j] = 27;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
