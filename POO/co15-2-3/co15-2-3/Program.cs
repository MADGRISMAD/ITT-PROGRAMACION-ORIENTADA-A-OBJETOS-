using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co15_2_3
{
    public class circulo
    {
        protected double radio;
        public circulo()
        {
            radio = 0;
        }
        public circulo(double radio)
        {
            Actualiza(radio);
        }
        public void Actualiza(double radio)
        {
            this.radio = radio;
        }
        public virtual double Area()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
        protected double Radio()
        {
            return radio;
        }
        public double Diametro()
        {
            return radio * 2;

        }
        public double Perimetro()
        {
            return Math.PI * Diametro();

        }


    }
    public class esfera : circulo
    {

        public Double volumen()
        {
            return 4 / 3 * Math.PI * Math.Pow(radio, 3);

        }
        public override double Area()
        {
            return base.Area() * 4;
            // return 4 * Math.PI * Math.Pow(radio, 2);
        }

    }
    public class balon : esfera
    {
        private String color;
        private int rebote;
        private double presion;
        public void inflar(double aire)
        {

        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            balon pelota = new balon();
            pelota.Actualiza(20);
            Console.WriteLine(pelota.Area());
            Console.WriteLine(pelota.volumen());
            Console.ReadLine();
        }
    }
}
