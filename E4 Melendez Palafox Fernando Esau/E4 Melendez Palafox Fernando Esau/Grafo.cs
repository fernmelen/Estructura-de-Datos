using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_Melendez_Palafox_Fernando_Esau
{
    class Grafo
    {
        public int NumVertices { get; set; } 
        List<int>[] Lista; 
        public Grafo(int Dato) 
        {
            NumVertices = Dato; 
            Lista = new List<int>[Dato]; 
            for (int i = 0; i < Dato; i++) 
            { Lista[i] = new List<int>(); }
        }
        public void Agregar(int i, int Valor) 
        { Lista[i].Add(Valor); }
        public void DFS(int Valor, int Dato) 
        {
            List<string> Ciudad = new List<string>();
            if (Dato == 1 || Dato == 2)
            {
                Ciudad.Add("Boston");
                Ciudad.Add("Chicago");
                Ciudad.Add("Denver");
                Ciudad.Add("LA");
                Ciudad.Add("New York");
                Ciudad.Add("San Francisco");
                Ciudad.Add("Miami");
                Ciudad.Add("Atlanta");
            }
            if (Dato == 3)
            {
                Ciudad.Add("Atlanta");
                Ciudad.Add("Chicago");
                Ciudad.Add("San Francisco");
                Ciudad.Add("Boston");
                Ciudad.Add("Denver");
                Ciudad.Add("LA");
                Ciudad.Add("New York");
                Ciudad.Add("Miami");
            }
            if (Dato == 4)
            {
                Ciudad.Add("Denver");
                Ciudad.Add("Chicago");
                Ciudad.Add("New York");
                Ciudad.Add("Atlanta");
                Ciudad.Add("San Francisco");
                Ciudad.Add("Boston");
                Ciudad.Add("LA");
                Ciudad.Add("Miami");
            }
            bool[] Visitados = new bool[NumVertices]; 
            Stack<int> Pila = new Stack<int>(); 
            Visitados[Valor] = true; 
            Pila.Push(Valor); 
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("El camino para el ultimo elmento es: ");          
            while (Pila.Count != 0) 
            {
                Valor = Pila.Pop(); 
                Console.Write("{0} ===> ", Ciudad[Valor]);               
                foreach (int item in Lista[Valor]) 
                {
                    if (!Visitados[item]) 
                    {
                        Visitados[item] = true; 
                        Pila.Push(item); 
                    }
                }
            }
            Console.Write("Fin de ruta");
        }
    }
}
