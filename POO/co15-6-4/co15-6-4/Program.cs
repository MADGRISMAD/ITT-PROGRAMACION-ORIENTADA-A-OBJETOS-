using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co15_6_4
{
    public abstract class Figura
    {
        string nombre;
        public Figura(string nombre)
        {
            this.nombre = nombre;
        }
        public abstract void Actualiza(string nombre);
        public abstract Double Area();
        public abstract string Ver();
        //public abstract override string ToString();
        public abstract double Perimetro();

    }
    public class poligonoR : Figura
    {
        protected string nombre;
        protected double noLados;
        protected double lados;
        public poligonoR(string nombre, double noLados, double lado) : base(nombre)
        {
            this.noLados = noLados;
            this.lados = lado;
        }
        public override void Actualiza(string nombre)
        {
            this.nombre = nombre;
        }
        public override string Ver()
        {
            return "";
        }
        public double Apotema()
        {
            return lados / 2 * Math.Tan(360 / noLados);
        }
        public override double Perimetro()
        {
            return noLados * lados;
        }
        public override double Area()
        {
            return (Perimetro() * Apotema()) / 2;

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            poligonoR poligono = new poligonoR("pentagono", 5, 4);
            Console.WriteLine(poligono.Area());
            Console.ReadLine();
        }
    }
}