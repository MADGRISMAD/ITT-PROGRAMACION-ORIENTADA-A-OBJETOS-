using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co15_8
{//constructores y destructores
    public class Lista
    {
        private int[] lista; // indica que guarda varios elementos
        private int SubIndice; //guarda la posicion del ultimo elemento
        public Lista() //declaracion implisita de constructor
        {
            lista = new int[10];
            SubIndice = 0;

        }
        public Lista(int cuantos)
        {
            lista = new int[cuantos];
            SubIndice = 0;
        }
        public Boolean actualia(int elemeto)
        {
            if (SubIndice < lista.Length)
                lista[SubIndice++] = elemeto;
            else
                return true; //lsita llena
            return false; //elemento insertado
        }
        public int Tamaño()
        {
            return lista.Length;
        }

        public int hay()
        {
            return SubIndice;

        }
        ~Lista() //destructor, es llamado de forma automatica cuanndo termina el programa
        {
            Console.WriteLine("fin");
            Console.ReadLine();
        }

    }
    class Program
    {

        static void Main(string[] args)//delaracion explicitta y si la 
        {//implisicita no se pone. marca errir su se describe

            Lista datos;
            datos = new Lista();// crea una lista de 10 elementos
            Lista datos2;
            datos2 = new Lista(18);// crea una lista de 18 elemtenos
            Console.WriteLine(datos.Tamaño());
            Console.WriteLine(datos2.Tamaño());
            Console.ReadKey();
            /*for (int ciclo = 0; ciclo < 25; ciclo++)
            
                if (datos.actualia(ciclo))
                    Console.WriteLine("elemento insertado");
                else
                    Console.WriteLine("lista llena");*/

            int a = 0;
            while (true)
                if (datos2.actualia(a++))
                    Console.WriteLine("elemento insertado");
                else
                    break;

            while (true && a < datos2.Tamaño())
                if (datos2.actualia(a++))
                    Console.WriteLine("elemento insertado");
                else
                    Console.WriteLine("lista llena");

            Console.ReadLine();




        }
    }
}
