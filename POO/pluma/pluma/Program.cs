using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluma
{
    public class Pluma
    {
        private string color;
        private int cantidad;
        private double precio;
        private double total;
        public Pluma()
        {
            precio = 10;
        }
        public void Captura()
        {
            Console.WriteLine("Ingrese color de pluma");
            color = Console.ReadLine();
            Console.WriteLine("Cuantas plumas: ");
            cantidad = int.Parse(Console.ReadLine());
            Calcula();
        }
        public void Calcula()
        {
            total = cantidad * precio;
        }
        public string Mostrar()
        {
            return "\n\nColor de pluma: " + color +
                "\nCantidad: " + cantidad +
                "\nprecio: " + precio +
                "\ntotal: " + total;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pluma pluma = new Pluma();
            pluma.Captura();
            Console.WriteLine(pluma.Mostrar());
            Console.ReadKey();
        }

    }
}