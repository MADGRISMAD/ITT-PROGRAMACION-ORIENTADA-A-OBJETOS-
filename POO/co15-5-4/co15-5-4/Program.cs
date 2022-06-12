using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co15_5_4
{
    public class Rectangulo
    {
        protected String nombre;
        protected Double ancho;
        protected Double largo;
        public Rectangulo()
        {

        }
        public Rectangulo(string nombre, double ancho, double largo)
        {
            Actualiza(nombre, ancho, largo);
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
            : base(nombre, ancho, largo)
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
        protected int loteMax;
        protected int manzanaMax;
        public Fraccionamiento(int loteMax, int manzanaMax)
        {
            PrivadaLaurel = new Terreno[loteMax, manzanaMax];
            this.loteMax = loteMax;
            this.manzanaMax = manzanaMax;
        }
        public Fraccionamiento()
        {
            //Una vez credo hay que llamar a crear
        }
        public void Crear(int loteMax, int manzanaMax)
        {
            PrivadaLaurel = new Terreno[loteMax, manzanaMax];
            this.loteMax = loteMax;
            this.manzanaMax = manzanaMax;
        }
        public int LoteMax()
        {
            return loteMax;
        }
        public int ManzanaMax()
        {
            return manzanaMax;
        }
        public Boolean Actualiza(int manzana, int lote, Terreno objeto)
        {
            if (manzana < manzanaMax && lote < loteMax)
                PrivadaLaurel[manzana, lote] = objeto;
            else
                return false;
            return true;
        }
        public String Ver(int manzana, int lote)
        {
            if (manzana < manzanaMax && lote < loteMax)
            {
                if (PrivadaLaurel[manzana, lote] != null)
                {
                    return PrivadaLaurel[manzana, lote].Ver();
                }
                else
                {
                    return ".";
                }
            }
            else
            {
                return ".";
            }
        }
    }
    public class Inicio
    {
        Fraccionamiento privada;
        public Inicio()
        {
            int lotes, manzanas;
            privada = new Fraccionamiento();
            Console.WriteLine("Indicar cuantos lotes tendra");
            lotes = int.Parse(Console.ReadLine());
            Console.WriteLine("Indicar cuantas manzanas tendra");
            manzanas = int.Parse(Console.ReadLine());
            privada.Crear(lotes, manzanas);
            Captura();
            Mostrar();
        }

        public void Captura()
        {
            string nombre;
            double largo;
            double ancho;
            double precio;
            int lote;
            int manzana;
            char opc;
            do
            {
                Console.WriteLine("Indicar el Nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Indicar el largo");
                largo = Double.Parse(Console.ReadLine());
                Console.WriteLine("Indicar el ancho");
                ancho = Double.Parse(Console.ReadLine());
                Console.WriteLine("Indicar el precio");
                precio = Double.Parse(Console.ReadLine());
                Console.WriteLine("Indicar el lote");
                lote = int.Parse(Console.ReadLine());
                Console.WriteLine("Indicar la Manzana");
                manzana = int.Parse(Console.ReadLine());
                Console.WriteLine("Desea continuar (S/N)");
                privada.Actualiza(lote, manzana, new Terreno(nombre, ancho, largo, precio));
                opc = Console.ReadKey().KeyChar;
            } while (opc != 'N');

        }
        public void CapturaD()
        {
            privada.Actualiza(0, 0, new Terreno("uno", 10, 5, 150));
            privada.Actualiza(0, 1, new Terreno("dos", 8, 16, 2100));
            privada.Actualiza(0, 2, new Terreno("tres", 3, 12, 1500));
            privada.Actualiza(0, 3, new Terreno("cuatro", 5, 7, 1000));
            privada.Actualiza(0, 4, new Terreno("cinco", 4, 9, 2200));

        }
        public void Mostrar()
        {
            string mensaje;

            for (int lotep = 0; lotep < privada.LoteMax(); lotep++)
                for (int manzanap = 0; manzanap < privada.ManzanaMax(); manzanap++)
                {
                    mensaje = privada.Ver(lotep, manzanap);
                    if (mensaje != ".")
                        Console.WriteLine(privada.Ver(lotep, manzanap));
                }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Inicio i = new Inicio();
            Console.ReadKey();
        }
    }
}