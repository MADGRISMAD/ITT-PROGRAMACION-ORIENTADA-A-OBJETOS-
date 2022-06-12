using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co15_05B_3
{
    public class Rectangulo
    {
        protected String nombre;
        protected Double ancho;
        protected Double largo;
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
            return "Nombre      :" + nombre +
                 "\nLargo       :" + largo +
                 "\nAncho       :" + ancho +
                 "\nArea        :" + Area() +
                 "\nPerimetro   :" + Perimetro();
        }
    }
    public class Terreno : Rectangulo
    {
        protected Double precio;
        public Terreno() { }
        public Terreno(Terreno objeto)
        {
            Actualiza(objeto.nombre, objeto.ancho, objeto.largo, objeto.precio);
        }
        public Terreno(String nombre, Double ancho, Double largo, Double precio)
        {
            Actualiza(nombre, ancho, largo, precio);
        }
        public void Actualiza(String nombre, Double ancho, Double largo, Double precio)
        {
            Actualiza(nombre, ancho, largo);
            this.precio = precio;
        }
        public override string Ver()
        {
            return base.Ver()
                + "\nPrecio metro:" + precio +
                  "\nTotal       :" + PrecioTotal();
        }
        public Double PrecioTotal() { return precio * Area(); }
    }
    public class Fraccionamiento
    {
        protected Terreno[,] PrivadaLaurel;
        public Fraccionamiento()
        {
            PrivadaLaurel = new Terreno[15, 20];
        }
        public void Actualiza(int manzana, int lote, Terreno objeto)
        {
            PrivadaLaurel[manzana, lote] = objeto;
        }
        public String Ver(int manzana, int lote)
        {
            return PrivadaLaurel[manzana, lote].Ver();
        }
    }
    public class Inicio
    {
        Fraccionamiento privada;
        public Inicio()
        {
            privada = new Fraccionamiento();
        }
        public void Captura()
        {
            privada.Actualiza(0, 0, new Terreno("uno", 10, 5, 150));
            privada.Actualiza(0, 1, new Terreno("dos", 8, 16, 2100));
            privada.Actualiza(0, 2, new Terreno("tres", 3, 12, 1500));
            privada.Actualiza(0, 3, new Terreno("cuatro", 5, 7, 1000));
            privada.Actualiza(0, 4, new Terreno("cinco", 4, 9, 2200));
            privada.Actualiza(0, 5, new Terreno("seis", 7, 8, 2300));
        }
        public void Mostrar()
        {
            for (int ciclo = 0; ciclo < 5; ciclo++)
                Console.WriteLine(privada.Ver(0, ciclo));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Inicio i = new Inicio();
            i.Captura();
            i.Mostrar();
            Console.ReadLine();
        }
    }
}
