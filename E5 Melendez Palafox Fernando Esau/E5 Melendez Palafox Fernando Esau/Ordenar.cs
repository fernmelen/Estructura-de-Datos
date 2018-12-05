using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_Melendez_Palafox_Fernando_Esau
{
    class Ordenar
    {
        public void ordenar(int [] arre)
        {
            int temporal;
            for (int i = 0; i < arre.Length; i++)  
            {
                for (int j = 0; j < arre.Length - 1; j++)  
                {
                    if (arre[j] > arre[j + 1])  
                    {
                        temporal = arre[j + 1];  
                        arre[j + 1] = arre[j];    
                        arre[j] = temporal;    
                    }
                }
            }
        }
        public void Imprimir(int[] arre)
        {
            foreach (var item in arre)
            {
                Console.Write("| " + item+" |");
            }
            Console.ReadKey();
        }
    }
}
