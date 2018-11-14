using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_2_Melendez_Palafox_Fernando_Esau
{
    class Nodo
    {
        public string nombre;      //Variable de tipo string 
        public Nodo[] vinculo;     //Arreglo de tipo Nodo llamado vinculo
        public Nodo() { }    //Constructor por defecto
        public Nodo(string nom)   //Construcutor sobrecargado
        {
            nombre = nom;    //Se asigna valor a la variable nombre
        }
    }
}
