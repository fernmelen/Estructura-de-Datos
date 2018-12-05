using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E____5_Melendez_Palafox_Fernando_E
{
    class Quick
    {
        public void QuickSort(int[] numeros, int menor, int mayor)  
        {
            int aux = menor, aux2 = mayor, pivote = (mayor + menor) / 2; int temp;  
            do
            {
                while (numeros[aux] < numeros[pivote]) { aux++; }  
                while (numeros[aux2] > numeros[pivote]) { aux2--; } 
                if (aux <= aux2)  
                {
                    temp = numeros[aux];  
                    numeros[aux] = numeros[aux2];  
                    numeros[aux2] = temp;   
                    aux++; aux2--;  
                }
            } while (aux <= aux2);  
            if (mayor > aux) { QuickSort(numeros, aux, mayor); }  
            if (menor < aux2) { QuickSort(numeros, menor, aux2); }  
        }
    }
}
