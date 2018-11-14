using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_2_Melendez_Palafox_Fernando_Esau
{
    class Arbol
    {
        int X = 0, Y = 2;      //Coordenadas para imprimir el Arbol ordenado
        public void Agregar(Nodo nodo1, string nom, string[] nombres)   //Agrega nodos
        {
            if (nodo1.vinculo != null)//Si el nodo actual es diferente de null
            {
                foreach (Nodo item in nodo1.vinculo) 
                {
                    Agregar(item, nom, nombres);//Se agrega otro nodo por cada vinculo encontrado en el nodo
                }
            }
            else
            {
                if (nodo1.nombre == nom)//Compara el nombre encontrado en el nodo con el actual ingresado
                {
                    nodo1.vinculo = new Nodo[nombres.Length];//se crea un nuevo arreglo para guardar otro arreglo dentro
                    for (int i = 0; i < nombres.Length; i++) 
                    {
                        nodo1.vinculo[i] = new Nodo(nombres[i]);//Se guardan los nombres de las ramas del arbol actual, metiendo un arreglo dentro de otro
                    }
                }
            }
        }
        int Altura = 0, Nivel = 0;//Variables para obtener los datos Altura y Nivel
        public void Imprimir(Nodo nodo1)//Metodo para imprimir los arboles
        {

            if (nodo1.vinculo != null) //Cuando el vinculo esta vacio entra al if
            {
                Console.SetCursorPosition(X, Y);//Ubicamos el cursor en las cordenadas...
                Console.Write(nodo1.nombre);//...para escribir el nombre 
                X += 5;//Se mueve la coordenada en "X" 5 unidades a la derecha 
                Y++;//Pasamos de renglon simando 1 a la coordenad en "Y"
                for (int i = 0; i < nodo1.vinculo.Length; i++) 
                {
                    Imprimir(nodo1.vinculo[i]);//Se imprime cada rama encontrada en el nivel 
                }
                X += 5;//Se Mueve a la derecha la Coordenada "X" 
            }
            else//Al no entrar en las condiciones anteriores 
            {
                Console.SetCursorPosition(X, Y);//Se Posiciona en las coordenadas
                Console.Write(nodo1.nombre);//y se imprime el nombre de la rama del arbol 
                Y++;//despues se baja un renglon en coordenada "Y"
            }

            Altura = ((Y - 1) / 2) - 1;//La altura se iguala a ((Y - 1) /2) - 1
            Nivel = Altura-1;// level se iguala a Altura -1 porque los niveles se cuentas desde cero
        }
        public void HeightLevel()//Metodo que imprime la Altura y Nivel 
        {
            Console.WriteLine("\n\nAltura: {0}", Altura);
            Console.WriteLine("Nivel: {0}", Nivel);
        }

        public void Imprimir1()//Metodo que imprime el arbol A 
        {
            Console.WriteLine("Arbol A");
            Nodo NodoRaiz = new Nodo("E");//Se crea la raiz con el Nombre "E"
            Arbol Arbolito = new Arbol();//Se crea un Arbol
            Arbolito.Agregar(NodoRaiz, "E", new string[] { "F", "A" });//Se agregan las primeras ramas como pide el ejercicio
            Arbolito.Agregar(NodoRaiz, "A", new string[] { "B", "C", "D" });//Se le agragan las otras ramas en el nivel siguiente
            Arbolito.Imprimir(NodoRaiz);//Imprime el arbol
            Arbolito.HeightLevel();//Imprime los valores de Altura y Nivel
            Console.WriteLine("Ruta al elemento mas largo: E > A > [B, C o D]");
            Console.ReadKey();
        }

        public void Imprimir2()
        {
            Console.WriteLine("Arbol B");
            Nodo NodoRaiz = new Nodo("C");//Se crea la raiz llamada "C"
            Arbol Arbolito = new Arbol();//Instanciamos el Arbol
            Arbolito.Agregar(NodoRaiz, "C", new string[] { "D", "F", "G", "A" });//Agrega las ramas al siguiente nivel
            Arbolito.Agregar(NodoRaiz, "A", new string[] { "B" });//agrega la rama B subsecuente de la "A"
            Arbolito.Agregar(NodoRaiz, "B", new string[] { "E" });//Agrega la rama E subsecuente de la "B"
            Arbolito.Imprimir(NodoRaiz);//Imprime el arbol 
            Arbolito.HeightLevel();//Imprime el Nivel y Altura
            Console.WriteLine("Ruta al elemento mas largo: C-->A-->B-->E");
            Console.ReadKey();
        }

        public void Imprimir3()
        {
            Console.WriteLine("Arbol C");
            Nodo NodoRaiz = new Nodo("K");//Se crea la raiz con nombre "K"
            Arbol Arbolito = new Arbol();//Se crea el arbol
            Arbolito.Agregar(NodoRaiz, "K", new string[] { "A", "C", "B", "D" });//Llenamos el siguiente nivel como requiere el ejercicio
            Arbolito.Agregar(NodoRaiz, "D", new string[] { "I    J", "E" });//igual
            Arbolito.Agregar(NodoRaiz, "E", new string[] { "F", "G" });//igual
            Arbolito.Agregar(NodoRaiz, "G", new string[] { "H" });//igual
            Arbolito.Imprimir(NodoRaiz);//Se imprime el arbol
            Arbolito.HeightLevel();//Se imprime la Altura y el Nivel
            Console.WriteLine("Ruta al elemento mas largo: K-->D-->E-->G-->H");
            Console.ReadKey();
        }
    }
}
