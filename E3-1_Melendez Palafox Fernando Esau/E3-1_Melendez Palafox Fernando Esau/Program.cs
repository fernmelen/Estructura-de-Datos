using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace E3_1_Melendez_Palafox_Fernando_Esau
{
    public class User
    {
        public ArrayList Cal = new ArrayList();      //Listas necesarias pata el almacenamiento de las calificaciones y alumnos
        public ArrayList alumnos = new ArrayList();
    }
    class Program
    {
        static void Main(string[] args)
        {
            User clase1 = new User();
            ArrayList Clases = new ArrayList();   //necesario poner este fuera para almacenar los objetos aqui dentro
            int menu = 0;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Sistema de almacenamiento de calificacione:" +    //menu
                        "\n1.-)Registrar una clase" +
                        "\n2.-)Ver clases" +
                        "\n3.-)Salir");
                    menu = int.Parse(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            
                            Console.Write("Ecriba el nombre de la clase: ");
                            string clase = Console.ReadLine(); Clases.Add(clase);
                            string opc;
                            do
                            {
                                Console.Write("Nombre del alumno: ");
                                string alumno = Console.ReadLine(); clase1.alumnos.Add(alumno);   //Registro de los alumnos
                                Console.Write("Escribir calificacion: ");
                                int cal = int.Parse(Console.ReadLine()); clase1.Cal.Add(cal);
                                Console.Write("Agregar otro alumno?: ");
                                opc = Console.ReadLine();
                            } while (opc.ToUpper() != "NO");
                            Clases.Add(clase1);
                            break;
                        case 2:
                            int cont=1;
                            Console.Write("Escoger una clase: ");
                            foreach (var item in Clases)
                            {
                                
                                Console.Write("{0}.-) {1}", cont, item);   //Despliegue de las materias
                                cont++;
                            }
                            Console.WriteLine();
                            int opcion = int.Parse(Console.ReadLine());  //seleccion del la materia
                            foreach(var item in clase1.alumnos)
                            {
                                int a = 0;
                                Console.Write("\n{0}------{1}", item, clase1.Cal[a]);a++;  //despliegue de las calificaciones
                            }
                            Console.ReadKey();
                            break;
                    }
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            } while (menu != 3);
        }
        
    }
}
