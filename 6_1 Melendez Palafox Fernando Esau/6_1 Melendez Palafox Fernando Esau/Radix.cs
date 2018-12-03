using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_Melendez_Palafox_Fernando_Esau
{
    class Radix
    {
        public void RaSort(int[]arre)//Metodo de ordenamiento con parametro de un arreglo
        {
            int i, j;//contadores
            int[] temp = new int[arre.Length];//arreglo temporal 
            for (int salto = 31; salto > -1; --salto)//ciclo de 31 repeticiones
            {
                j = 0;//empezar contador en cero
                for (i = 0; i < arre.Length; ++i)//metodo segun largo del arreglo del parametro
                {
                    bool mover = (arre[i] << salto) >= 0;  //Comparacion por medio de un boleano
                    if (salto == 0 ? !mover : mover)  //Condicion que compara contador con boleano
                        arre[i - j] = arre[i];  //Posisciona el numero menor en la del mayor
                    else                            //Predeterminado
                        temp[j++] = arre[i];  //Copia el arreglo parametro con el temporal
                }
                Array.Copy(temp, 0, arre, arre.Length - j, j);  //Guarda los datos del arreglo temporal al parametro
            }
        }
    }
}
