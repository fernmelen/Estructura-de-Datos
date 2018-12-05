using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E__5_Melendez_Palafox_Fernando_Esau
{
    class Radix
    {
        public void RaSort(int[] arre)
        {
            int i, j;
            int[] temp = new int[arre.Length];
            for (int salto = 31; salto > -1; --salto)
            {
                j = 0;
                for (i = 0; i < arre.Length; ++i)
                {
                    bool mover = (arre[i] << salto) >= 0;  
                    if (salto == 0 ? !mover : mover)  
                        arre[i - j] = arre[i];  
                    else                            
                        temp[j++] = arre[i];  
                }
                Array.Copy(temp, 0, arre, arre.Length - j, j);  
            }
        }
    }
}
