using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co8
{
    public class Lista
    {
        private int[] lista; // indica que guarda varios elementos 
        private int subIndice; //Guarda la posicion del ultimo elemento
        public Lista()  //Declaracion implicita del constructor 
        {  //Si lo incluimos como en este caso se vuelve explicito
            lista = new int[10];
            subIndice = 0;
        }
        public Lista(int cuantos) //Declaracion explicita y si la implicita se pone, marca error si se describe
        {
            lista = new int[cuantos];
            subIndice = 0;
        }
        public int Mostrar(int noElementos)
        {
            if (noElementos < subIndice)
                return lista[noElementos];
            else
                return -1;
        }
        public Boolean actualiza(int elemento)
        {
            if (subIndice < lista.Length)
                lista[subIndice++] = elemento;
            else
                return false; //Lista llena
            return true; //elemento incertado

        }
        public int Tamano()
        {
            return lista.Length;
        }
        public int Hay()
        {
            return subIndice;
        }

        ~Lista() //Destructor es llamado de forma automatica cando termina el programa
        {
            Console.WriteLine("Fin");
            Console.ReadLine();
        }
    }
    public class Proceso
    {
        private Lista datos;
        public Proceso()
        {
            inicia();
        }
        public void inicia()
        {
            int cuantos = 0;
            Console.WriteLine("Cuantos elementos");
            cuantos = int.Parse(Console.ReadLine());
            datos = new Lista(cuantos);
            Menu();
        }
        public void Captura()
        {
            char opcion;
            int noValor = 0;
            Boolean ok;
            do
            {

                Console.Clear();
                Console.Write("{0}/{1}.- Indicar valor", noValor, datos.Tamano());
                ok = datos.actualiza(int.Parse(Console.ReadLine()));
                Console.WriteLine(ok ? "Elemento insertado" : "Lista llena");
                opcion = Console.ReadKey().KeyChar;
            } while (opcion != 'S' && opcion != 's');

        }

        public void Mostrar()
        {
            for (int ciclo = 0; ciclo < datos.Hay(); ciclo++)
                Console.WriteLine(datos.Mostrar(ciclo));
        }

        public void Menu()
        {
            char opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("C.- Captura ");
                Console.WriteLine("U.- Mostrar uno");
                Console.WriteLine("S. Salida");
                Console.WriteLine("M.- Mostrar todos");
                opcion = Console.ReadKey().KeyChar;
                switch (opcion)
                {
                    case 'C': Captura(); break;
                    case 'M': Captura(); break;
                }

            } while (opcion != 'S' && opcion != 's');
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Proceso proceso = new Proceso();
        }
    }
}