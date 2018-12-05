using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E___Melendez_Palafox_Fernando_Esau
{
    class Shell
    {
        public void ShellSort(int[]arre)
        {
            int salto = 0;
            int sw = 0;
            int temp = 0;
            int i = 0;
            salto = arre.Length / 2;
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    i = 1;
                    while (i <= (arre.Length - salto))
                    {
                        if (arre[i - 1] < arre[(i - 1) + salto])
                        {
                            temp = arre[(i - 1) + salto];
                            arre[(i - 1) + salto] = arre[i - 1];
                            arre[(i - 1)] = temp;
                            sw = 1;
                        }
                        i++;
                    }
                }
                salto = salto / 2;
            }
        }
    }
}
