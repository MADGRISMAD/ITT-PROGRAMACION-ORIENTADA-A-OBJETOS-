using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co15_1T_4
{
    public abstract class Parcial
    {
        protected String nombre;
        public abstract String Ver();
    }
    public class Minima : Parcial
    {
        protected int valor;
        public override String Ver()
        {
            return "\n Nombre       :" + nombre +
                   "\n Ver          :" + valor;
        }
        public Minima(String nombre, int valor)
        {
            this.nombre = nombre;
            this.valor = valor;
        }
        public String Nombre() { return nombre; }
        public int Valor() { return valor; }
    }
    public class Rectangulo
    {
        protected String nombre;
        protected Double ancho;
        protected Double largo;
        public Rectangulo(String nombre, Double ancho, Double largo)
        {
            Actualiza(nombre, ancho, largo);
        }
        public Rectangulo(Double ancho, Double largo, String nombre)
        {
            Actualiza(nombre, largo, ancho);
        }
        public void Actualiza(String nombre, Double ancho, Double largo)
        {
            this.nombre = nombre;
            this.ancho = ancho;
            this.largo = largo;
        }
        public Double Area()
        {
            return ancho * largo;
        }
        public Double Perimetro()
        {
            return ancho * 2 + largo * 2;
        }
        public Double Profundidad() { return largo; }
        public Double Ancho() { return ancho; }
        public virtual String Ver()
        {
            return "\nNombre      :" + nombre +
                   "\nLargo       :" + largo +
                   "\nAncho       :" + ancho +
                   "\nArea        :" + Area() +
                   "\nPerimetro   :" + Perimetro();
        }
    }
    public class Tarea
    {
        protected int codigo;
        protected Double puntosMax;
        protected Double puntos;
        protected String nombre;
        public Tarea(int codigo, Double puntosMax, Double puntos, String nombre)
        {
            Actualiza(codigo, puntosMax, puntos, nombre);
        }
        public void Actualiza(int codigo, Double puntosMax, Double puntos, String nombre)
        {
            this.codigo = codigo;
            this.puntosMax = puntosMax;
            this.puntos = puntos;
            this.nombre = nombre;
        }
        public Tarea() { }
        public Double Calificacion()
        {
            return puntos / puntosMax * 100;
        }
        public String Ver()
        {
            return "\nTareas       :" + nombre +
                   "\nCodigo       :" + codigo +
                   "\nCalificacion :" + Calificacion();
        }
    } //Plantillas.... Template
    public class Lista<Clase>
    {
        protected int posicion;
        protected int maximo;
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
    public class Inicio
    {
        public void ProcesoA()
        {
            Random azar = new Random();
            Tarea tempo = null;
            Lista<Tarea> lista;
            lista = new Lista<Tarea>(10);
            for (int a = 0; a < 10; a++)
                lista.Agregar(new Tarea(a + 1, 100, azar.Next(0, 100), "Tarea" + (a + 1)));
            for (int a = 0; a < 10; a++)
            {
                tempo = lista.Obtiene(a);
                Console.WriteLine(tempo.Ver());
            }
            Console.ReadKey();
        }
        public void ProcesoB()
        {
            Random azar = new Random();
            Rectangulo tempo = null;
            Lista<Rectangulo> lista;
            lista = new Lista<Rectangulo>(10);
            for (int a = 0; a < 10; a++)
                lista.Agregar(new Rectangulo("Rectangulo" + (a + 1), azar.Next(1, 30), azar.Next(1, 30)));
            for (int a = 0; a < 10; a++)
            {
                tempo = lista.Obtiene(a);
                Console.WriteLine(tempo.Ver());
            }
            Console.ReadKey();
        }
        public void ProcesoC()
        {
            Minima algo = null;
            Lista<Minima> objeto;
            objeto = new Lista<Minima>(20);
            for (int a = 0; a < 10; a++)
                objeto.Agregar(new Minima("Minima" + a, a + 2));
            for (int a = 0; a < 10; a++)
            {
                algo = objeto.Obtiene(a);
                Console.Write("\t" + algo.Nombre() + "Valor" + algo.Valor());
            }
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Inicio i;
            i = new Inicio();
            i.ProcesoA();
            i.ProcesoB();
            i.ProcesoC();
        }
    }
}