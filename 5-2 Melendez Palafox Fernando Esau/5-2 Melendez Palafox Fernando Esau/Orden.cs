using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_Melendez_Palafox_Fernando_Esau
{
    class Orden
    {
        public void QuickSort(double[] numeros, int menor, int mayor)  //metodo requerido
        {
            int aux = menor, aux2 = mayor, pivote = (mayor+menor) / 2; double temp;  //axiliares mas operaciones
            do
            {
                while (numeros[aux] < numeros[pivote]) { aux++; }  //Comparar para dejar a los menores del lado izquierdo
                while (numeros[aux2] > numeros[pivote]) { aux2--; } //Comparar para dejar a los mayores a la derecha
                if (aux <= aux2)  //comparar el menor con el mayor hasta que se intercepten termina
                {
                    temp = numeros[aux];  //guardamos el numero mayor en la temporal
                    numeros[aux] = numeros[aux2];  //los igualamos al menor ambos
                    numeros[aux2] = temp;   //del lado derecho dejamos al mayor
                    aux++; aux2--;  //acercamos mas las auxiliares que eran los limites del arreglo
                }
            } while (aux <= aux2);  //condicion de ejecucion hasta que los auxiliares de limites se intercepten
            if (mayor > aux) { QuickSort(numeros, aux, mayor); }  //recursividad del metodo para reducir el pivote en medio de los mayores
            if (menor < aux2) { QuickSort(numeros, menor, aux2); }  //recursividad igual pero con los menores
        }
        public void Imprimir(double[] ordenados)
        {
            QuickSort(ordenados, 0, ordenados.Length-1);  //volvemos a llamar al metodo una vez mas para corregir los errores 
            for (int i = 0; i < ordenados.Length; i++)
            {
                Console.Write("| " + ordenados[i] + " |");// imprimir cada elemento del arreglo una vez ya ordenado
            }
        }
    }
}
