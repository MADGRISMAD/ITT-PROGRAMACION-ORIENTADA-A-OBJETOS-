using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co15_5_3
{
    public class Rectangulo
    {
        protected string nombre;
        protected Double ancho, profundidad;
        public void Actualiza(double ancho, double alto, string nombre)
        {
            this.profundidad = alto;
            this.ancho = ancho;
            this.nombre = nombre;
        }
        public Double Area()
        {
            return ancho * profundidad;
        }
        public double Perimetro()
        {
            return ancho * 2 + profundidad * 2;
        }
        public double Profundidad()
        {
            return profundidad;
        }
        public double Ancho()
        {
            return ancho;
        }


    }
    public class prisma : Rectangulo
    {
        protected double alto;
        public void Actualiza(string nombre, double ancho, double profundidad, double alto)
        {
            this.alto = alto;
            Actualiza(nombre, ancho, profundidad,alto);
        }
        public double Volumen()
        {
            return ancho * ancho * profundidad;
        }
    }
    public class Contenedor : prisma
    {
        protected String material;
        protected Contenedor[] objetos;
        protected int noelemento;
        public Contenedor(int noelementos)
        {
            objetos = new Contenedor[noelementos];
        }
        public void Actualiza(Contenedor objeto)
        {
            objetos[noelemento++] = objeto;

        }
        public String Ver(int posicion)
        {
            return "nombre:\t\t" + objetos[posicion].nombre +
                   "altura:\t\t" + objetos[posicion].profundidad +
                   "anchura\t\t" + objetos[posicion].ancho +
                   "volumen\t\t" + objetos[posicion].Volumen() +
                   "perimetro\t\t" + objetos[posicion].Perimetro();
        }
        public void Mostrar()
        {
            for (int ciclo = 0; ciclo < noelemento; ciclo++)
            {
                Console.WriteLine(Ver(ciclo));
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Contenedor estacionamiento = new Contenedor(15);

        }
    }
}
