using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E3_Melendez_Palafox_Fernando_Esau
{
    class Operacion
    {
        public Stack Lista = new Stack();
        public Queue Cola = new Queue();

        public void Ejercicio1()
        {
            //¿Qué valores se devuelven durante la siguiente serie de operaciones de pila,
            //si se ejecutan en una pila inicialmente vacía ?
            //push(5), push(3), pop(), push(2), push(8),
            //pop(), pop(), push(9), push(1), pop(), push(7), push(6), pop(), pop(), push(4),
            //pop(), pop()
            Console.WriteLine("Ejercicio 1");
            Lista.Push(5);Lista.Push(3);
            Lista.Pop();
            Lista.Push(2);Lista.Push(8);
            Lista.Pop();Lista.Pop();
            Lista.Push(9);Lista.Push(1);
            Lista.Pop();
            Lista.Push(7);Lista.Push(6);
            Lista.Pop();Lista.Pop();
            Lista.Push(4);
            Lista.Pop();Lista.Pop();
            Console.WriteLine("Contenido de la Pila: ");
            foreach(var item in Lista)
            { Console.Write(" |" + item + "| "); }
            Console.ReadKey();
        }

        public void Ejercicio2()
        {
            //Escriba en este metodo un modulo que pueda leer  y almacenar palabras reservadas en una lista enlazada 
            //e identificadores y literales en Otra lista enlazada.
            //Cuando el programa haya terminado de leer la entrada, mostrar
            //Los contenidos de cada lista enlazada.
            //Revise que es un Identificador y que es un literal
            Console.Clear();
            Console.WriteLine("Ejercicio 2");
            LinkedList<string> ListaLig = new LinkedList<string>();
            ListaLig.AddLast("abstract"); ListaLig.AddLast("enum"); ListaLig.AddLast("long"); ListaLig.AddLast("stackalloc");
            ListaLig.AddLast("as"); ListaLig.AddLast("event"); ListaLig.AddLast("namespace"); ListaLig.AddLast("static");
            ListaLig.AddLast("base"); ListaLig.AddLast("explicit"); ListaLig.AddLast("new"); ListaLig.AddLast("string");
            ListaLig.AddLast("bool"); ListaLig.AddLast("extern"); ListaLig.AddLast("null"); ListaLig.AddLast("struct");
            ListaLig.AddLast("break"); ListaLig.AddLast("false"); ListaLig.AddLast("object"); ListaLig.AddLast("switch");
            ListaLig.AddLast("byte"); ListaLig.AddLast("finally"); ListaLig.AddLast("operator"); ListaLig.AddLast("this");
            ListaLig.AddLast("case"); ListaLig.AddLast("Fixed"); ListaLig.AddLast("out"); ListaLig.AddLast("throw");
            ListaLig.AddLast("catch"); ListaLig.AddLast("float"); ListaLig.AddLast("override"); ListaLig.AddLast("true");
            ListaLig.AddLast("char"); ListaLig.AddLast("for"); ListaLig.AddLast("params"); ListaLig.AddLast("try");
            ListaLig.AddLast("checked"); ListaLig.AddLast("foreach"); ListaLig.AddLast("private"); ListaLig.AddLast("typeof");
            ListaLig.AddLast("class"); ListaLig.AddLast("goto"); ListaLig.AddLast("protected"); ListaLig.AddLast("unit");
            ListaLig.AddLast("const"); ListaLig.AddLast("if"); ListaLig.AddLast("public"); ListaLig.AddLast("ulong");
            ListaLig.AddLast("continue"); ListaLig.AddLast("implicit"); ListaLig.AddLast("readonly"); ListaLig.AddLast("unchecked");
            ListaLig.AddLast("decimal"); ListaLig.AddLast("in"); ListaLig.AddLast("ref"); ListaLig.AddLast("unsafe");
            ListaLig.AddLast("default"); ListaLig.AddLast("int"); ListaLig.AddLast("return"); ListaLig.AddLast("ushort");
            ListaLig.AddLast("delegate"); ListaLig.AddLast("interface"); ListaLig.AddLast("sbyte"); ListaLig.AddLast("using");
            ListaLig.AddLast("do"); ListaLig.AddLast("internal"); ListaLig.AddLast("sealed"); ListaLig.AddLast("virtual");
            ListaLig.AddLast("double"); ListaLig.AddLast("is"); ListaLig.AddLast("short"); ListaLig.AddLast("void");
            ListaLig.AddLast("else"); ListaLig.AddLast("lock"); ListaLig.AddLast("sizeof"); ListaLig.AddLast("while");
            LinkedList<char> Identf = new LinkedList<char>();
            Identf.AddLast('a'); Identf.AddLast('b'); Identf.AddLast('c'); Identf.AddLast('d'); Identf.AddLast('e');
            Identf.AddLast('f'); Identf.AddLast('g'); Identf.AddLast('h'); Identf.AddLast('i'); Identf.AddLast('j');
            Identf.AddLast('k'); Identf.AddLast('l'); Identf.AddLast('m'); Identf.AddLast('n'); Identf.AddLast('o');
            Identf.AddLast('p'); Identf.AddLast('q'); Identf.AddLast('r'); Identf.AddLast('s'); Identf.AddLast('t');
            Identf.AddLast('u'); Identf.AddLast('v'); Identf.AddLast('w'); Identf.AddLast('x'); Identf.AddLast('y');
            Identf.AddLast('z');
            int op = 0;
            LinkedList<string> Reservadas = new LinkedList<string>();
            LinkedList<string> Identificadores = new LinkedList<string>();
            do
            {
                Console.Write("Escriba una palabra: ");
                string palabra = Console.ReadLine();
                if (Identf.Contains(palabra[1]))
                {
                    if (ListaLig.Contains(palabra)) { Reservadas.AddLast(palabra); }
                    else { Identificadores.AddLast(palabra); }
                }
                Console.Write("Desea esribir otra palabra? <1>Si , <2>No :");
                op = int.Parse(Console.ReadLine());
                
            } while (op != 2);
            Console.WriteLine("Lista de palabras reservadas de C#:");
            foreach (var item in Reservadas)
            { Console.Write(" |"+item+" |"); }
            Console.WriteLine("\nLista de identificadores y literales:");
            foreach (var item in Identificadores)
            { Console.Write(" |" + item + " |"); }
            Console.ReadKey();
        }

        public void Ejercicio3()
        {
            //mida el tiempo entre Un lista ligada y una lista normal en el tiempo de ejecucion de 9876 elementos agregados.
            Console.Clear();
            Console.WriteLine("Ejercicio 3");
            List<int> Lista = new List<int>();
            LinkedList<int> Ligada = new LinkedList<int>();
            Stopwatch T1 = new Stopwatch();T1.Start();
            for(int i = 0; i < 9876; i++)
            {
                Lista.Add(i);
            }
            T1.Stop();
            Stopwatch T2 = new Stopwatch();T2.Start();
            for (int i = 0; i < 9876; i++)
            {
                Ligada.AddLast(i);
            }
            T2.Stop();
            Console.WriteLine("El tiempo de ejecucion de una lista es: {0} \nEl tiempo de Ejecucion de una Lista ligada es: {1}", T1.Elapsed.ToString(), T2.Elapsed.ToString());
            Console.ReadKey();
        }

        public void Ejercicio4()
        {
            // Diseñar e implementar una clase que le permita a un maestro hacer un seguimiento de las calificaciones
            // en un solo curso.Incluir métodos que calculen la nota media, la
            //calificacion más alto, y el calificacion más bajo. Escribe un programa para poner a prueba tu clase.
            //implementación. Minimo 30 Calificaciones, de 30 alumnos.
            Console.Clear();
            Console.WriteLine("Ejercicio 4");
            Stack Clases = new Stack();
            Console.Write("Escriba el nombre de el maestro: ");
            string maestro = Console.ReadLine();
            int menor = 100;int mayor = 0;int suma = 0;int cont = 0;int amenor = 0; int amayor = 0;
            for (int i = 0; i < 30; i++)
            {
                Console.Clear();
                Console.Write("Escriba el nombre del alumno #{0}: ", i + 1);
                string alumno = Console.ReadLine();
                Console.Write("Escriba el nombre de la clase #{0}: ", i + 1);
                string nomcla = Console.ReadLine();
                Console.Write("Escriba la calificacion del alumno #{0}: ", i + 1);
                int cali = int.Parse(Console.ReadLine());
                Clase alum = new Clase(maestro, alumno, nomcla, cali);
                Clases.Push(alum);
            }
            foreach (int item in Clases)
            {
                if (item < menor) { menor = item;amenor = cont; }
                if (item > mayor) { mayor = item;amayor = cont; }
                suma = item + suma;cont++;
            }
            Console.WriteLine("El Alumno #{0} de menor calificacion tiene: {1} \nEl Alumno #{2} de mayor calificacion tiene: {3} \nLa calificacion media es: {4}", amenor, menor, amayor, mayor, suma / 30);
            Console.ReadKey();
        }
    }
}
