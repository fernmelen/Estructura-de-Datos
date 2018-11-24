using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_Melendez_Palafox_Fernando_Esau
{
    class Imprimir
    {
        public void Desplegar()
        {
            int Menu;
            do
            {
                Console.Clear();
                Console.WriteLine("Seleccione una Ruta\n1) Boston a Los Aangeles\n2)NewYork a San Francisco\n3)Atlanta a San Francisco\n4)Denver a NewYork\n5)Salir");
                Menu = int.Parse(Console.ReadLine());
                switch (Menu)
                {
                    case 1:
                        Grafo grafo1 = new Grafo(5);
                        grafo1.Agregar(0, 1);
                        grafo1.Agregar(1, 2);
                        grafo1.Agregar(2, 3);
                        grafo1.DFS(0, 1);
                        Console.WriteLine("\n\nPresione para continuar...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Grafo grafo2 = new Grafo(7);
                        grafo2.Agregar(0, 1);
                        grafo2.Agregar(1, 2);
                        grafo2.Agregar(2, 3);
                        grafo2.Agregar(4, 5);
                        grafo2.DFS(4, 2);
                        Console.WriteLine("\n\nPresione para continuar...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Grafo grafo3 = new Grafo(4);
                        grafo3.Agregar(0, 1);
                        grafo3.Agregar(1, 2);
                        grafo3.DFS(0, 3);
                        Console.WriteLine("\n\nPresione para continuar...");
                        Console.ReadKey();
                        break;
                    case 4:
                        Grafo grafo4 = new Grafo(4);
                        grafo4.Agregar(0, 1);
                        grafo4.Agregar(1, 2);
                        grafo4.DFS(0, 4);
                        Console.WriteLine("\n\nPresione para continuar...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Presione <enter> para salir del programa");
                        Console.ReadKey();
                        break;
                }
            }while(Menu != 5);
        }
        
    }
}
