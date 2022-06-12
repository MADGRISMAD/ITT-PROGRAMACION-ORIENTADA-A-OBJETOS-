using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co15_1t_4
{
    public class Tarea
    {
        protected int codigo;
        protected int puntosMax;
        protected int puntos;
        protected string nombre;
        public Tarea(int codigo, int puntosMax, int puntos, string nombre)
        {
            Actualiza(codigo, puntosMax, puntos, nombre);
        }
        public void Actualiza(int codigo, int puntosMax, int puntos, string nombre)
        {
            this.codigo = codigo;
            this.puntosMax = puntosMax;
            this.puntos = puntos;
            this.nombre = nombre;
        }
        public Tarea() { }
        public int Calificacion()
        {
            return puntos / puntosMax * 100;
        }
        public string Ver()
        {
            return "\n Tarea       :" + nombre +
                   "\n Codigo      :" + codigo +
                   "\n Calificacion:" + Calificacion();
        }

    }
    public class Lista<Clase>
    {
        protected int posicion, maximo;
        protected Clase[] lista;
        public Lista(int numElementos)
        {
            maximo = numElementos;
            posicion = 0;
            lista = new Clase[maximo];
        }
        public Boolean Agregar(Clase objeto)
        {
            if (posicion < maximo)

            {
                lista[posicion++] = objeto;
                return true;
            }
            return false;
        }
        public Clase Obtiene(int posicion)
        {
            return lista[posicion];
        }
    }
    public class inicio
    {
        public void ProcesoA()
        {
            Random azar = new Random();
            Tarea tempo = null;
            Lista<Tarea> lista;
            lista = new Lista<Tarea>(10);
            int numeroaleatorio = azar.Next(0, 99);
            for (int a = 0; a < 10; a++)
            {
                lista.Agregar(new Tarea(a + 1, 100, numeroaleatorio, "tarea" + (a + 1)));

            }
            for (int a = 0; a < 10; a++)
            {
                tempo = lista.Obtiene(a);
                Console.WriteLine(tempo.Ver());

            }
            Console.ReadKey();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            inicio i;
            i = new inicio();
            i.ProcesoA();


        }
    }
}
