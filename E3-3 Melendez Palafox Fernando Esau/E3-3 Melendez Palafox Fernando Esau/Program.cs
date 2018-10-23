using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_3_Melendez_Palafox_Fernando_Esau
{
    
    class Carta
    {
        public int NC;public int Valor;      //Utilizo mis variables para almacerar el todas las propiedades de cada carta
        public string Denominacion;         //Como string escribo la denominacion de la carta y la modifico segun su caso
        Random R1 = new Random();          //por medio de un aleatorio le doy las propiedades a la carta
        public string Asignar()             //Con este metodo decido que simbolo es la carta dividendo el rango del numero random en cuatro secciones
        {
            NC = R1.Next(1, 52);          //El random abarca 52 cartas
            if (NC < 13) { return Denominacion = "♠"; }   //La primer denominacion abarca 13 cartas conmo la baraja americana
            else if (NC > 13 && NC < 26) { return Denominacion = "♣"; }  //Devuelvo en cada posibilidad su respectivo simbolo
            else if (NC > 26 && NC < 39) { return Denominacion = "♥"; }
            else { return Denominacion = "♦"; } 
        }
        public string DenominarCarta()  //En este metodo le doy valor a cada carta segun el numero random y agrego el numero a la denominacion para hacerlo string
        {
                if (NC >= 1 && NC <= 13)
                {
                    if (NC == 1) { Valor = 11; return Denominacion = "As " + Denominacion; }//Doy valor de segun el numero de carta
                    if (NC == 11) { Valor = 10; return Denominacion = "J " + Denominacion; }
                    if (NC == 12) { Valor = 10; return Denominacion = "Q " + Denominacion; }
                    if (NC == 13) { Valor = 10; return Denominacion = "K " + Denominacion; }
                else { Valor = NC; return Denominacion = Valor.ToString() + " " + Denominacion; }//Cuando el valor no es especial lo dejo como el numero inicial
                }
                else if (NC > 13 && NC <= 26)
                {
                    if (NC == 14) { Valor = 11; return Denominacion = "As " + Denominacion; }
                    if (NC == 24) { Valor = 10; return Denominacion = "J " + Denominacion; }
                    if (NC == 25) { Valor = 10; return Denominacion = "Q " + Denominacion; }
                    if (NC == 26) { Valor = 10; return Denominacion = "k " + Denominacion; }
                else { Valor = NC-13; return Denominacion = Valor.ToString() + " " + Denominacion; }// le resto la diferencia del random para obtener el valor
            }
                else if (NC > 26 && NC <= 39)
                {
                    if (NC == 27) { Valor = 11; return Denominacion = "As " + Denominacion; }
                    if (NC == 37) { Valor = 10; return Denominacion = "J " + Denominacion; }
                    if (NC == 38) { Valor = 10; return Denominacion = "Q " + Denominacion; }
                    if (NC == 39) { Valor = 10; return Denominacion = "k " + Denominacion; }
                else { Valor = NC-26; return Denominacion = Valor.ToString() + " " + Denominacion; }
            }
                else if (NC > 39 && NC <= 52)
                {
                    if (NC == 40) { Valor = 11; return Denominacion = "As " + Denominacion; }
                    if (NC == 50) { Valor = 10; return Denominacion = "J " + Denominacion; }
                    if (NC == 51) { Valor = 10; return Denominacion = "Q " + Denominacion; }
                    if (NC == 52) { Valor = 10; return Denominacion = "k " + Denominacion; }
                else { Valor = NC-39; return Denominacion = Valor.ToString() + " " + Denominacion; }
            }
            else { return Denominacion = "Error de carta # " + NC.ToString(); }//Debug en caso de error
            
        }
        public void Asing() { Asignar(); DenominarCarta(); }//Ejecuto los metodos a travez de otro
    }
    public class Operaciones  //En una clase aparte ejecuto todas mis operaciones
    {
        int suma;public int Contador;public int JuegosPerdidos;public int JuegosGanados;int ValCarta;//Son todas las variables para comparar, almacenar o contar
        Stack<Carta> Cartas = new Stack<Carta>(); //Almaceno los objetos de cada carta en esta pila
        public void Comparar()  //Metodo para comparar las cartas y saber si gano o perdio
        {
            if (suma == 21 && Contador < 5) { Console.WriteLine("Ganaste perro!\nPresiona <enter>");JuegosGanados++;Console.ReadKey(); Console.Clear();Intro();suma = 0;Contador = 0; }
            //Cuando la suma de las cartas es igual a 21 y no se excede el limite de cinco cartas se gana la partida
            else if (suma < 21 && Contador < 5) { Menu();}  //Cuando la suma de las cartas es menor a 21 y el numero de cartas menor a 5 la partida continua
            else  
            {
                if (ValCarta == 11 && Contador < 5) { suma = suma - 10;Comparar(); }  //Cuando la ultima carta es un as y la suma excede 21, el juego utiliza el as como 1 a favor de la partida
                Console.WriteLine("Haz perdido!\nPresiona <enter>");JuegosPerdidos++;Console.ReadKey(); Console.Clear();Intro();  //Se pierde el juego cuando se exceden las 5 cartas o una suma de 21 y vuelve al inicio
                suma = 0;Contador = 0;  //Se reinician contadores de partida
            }
        }
        public void Intro() { Contador = 0;suma = 0; Console.WriteLine("Simulacion BlackJack v1.0\nSus cartas de inicio son:");DesplegarCarta();DesplegarCarta();Comparar(); }
        // Inicio de la partida con dos cartas y un menu de bienvenida al mismo tiempo que los contadores se resetean
        public void DesplegarCarta()  //Este metodo hace todo el proceso de desplegar una carta
        {
            Carta C = new Carta();  //Se crea el objeto de la carta
            C.Asing();  //Se ejecutan los metodos del objeto
            Cartas.Push(C);  //Se almacena el objeto en una pila
            var actual = Cartas.Pop();  //Se extrae y almacena el objeto en una variable
            ValCarta = actual.Valor;  //Extraemos el valor de la carta de la variable
            Console.Write("| " + actual.Denominacion + " |"); //Se despliega la carta en consola
            Contador++;  //Se aumenta el contador por cada carta
            suma = suma + ValCarta;  //Se suma el valor de la carta a una variable externa al metodo
        }
        public void Menu()  //Es la interfaz del usuario, como menu
        {
            try
            { 
            Console.WriteLine("Desea continuar?\n 1. Si\n 2. No");  //Se le pregunta al usuario y captura si desea continuar jugando
            int menu = int.Parse(Console.ReadLine());
            switch (menu)  //Se ejecuta una opcion elejida
            {
                case 1:  //Al elegir continuar se mandan llamar mas metodos
                    DesplegarCarta();  //Se despliega otra carta
                    Comparar(); //Se compara la suma de las cartas en partida actual despues de agregar una
                    break;
                case 2:  //En caso de querer terminar el juego se ejecuta lo siguiente..
                    try
                    {//Se despliegan los juegos ganados y perdidos asi como los jugados antes de salir
                        Console.WriteLine("Juegos Jugados: {0}\nJuegos ganados: {1}\nJuegos perdidos: {2}", JuegosGanados + JuegosPerdidos, JuegosGanados, JuegosPerdidos);
                        throw new Exception("Game Over\nPress <enter>"); //Para terminar el ciclo del juego lanzo la excepcion controlada con el mensaje de final
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); Console.ReadKey(); }  //Despliego el mensaje final para el jugador y espero su salida
                    break;
            }
            }
            catch (FormatException) { Menu(); }  //Atrapo las opciones erroneas en el menu y lo vuelvo a ejecutar
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones Usuario = new Operaciones();Usuario.Intro();  //Mantengo limpio el Main y ejecuto el metodo del objeto que inicia el ciclo del juego
        }
    }
}
