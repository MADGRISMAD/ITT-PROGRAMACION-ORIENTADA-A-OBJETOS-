using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co47
{
    public struct Comanda
    {
        public int noComida;
        public string nombre;
        public double precio;
    }
    public class Mesero
    {
        private String nombre;
        private int noMesero;
        private Comanda[] misNotas;
        private int noPlatillos;

        public Mesero(int cantidad)
        {
            misNotas = new Comanda[cantidad];
            noPlatillos = 0;
        }
        public void Captura()
        {
            Console.WriteLine("Indicar nombre de mesero");
            nombre = Console.ReadLine();
            Console.WriteLine("Indicar numero de mesero");
            noMesero = int.Parse(Console.ReadLine());
        }
        public void Pedido()
        {
            do
            {
                Console.WriteLine("Indicar el numero de platillo");
                misNotas[noPlatillos].noComida = int.Parse(Console.ReadLine());
                Console.WriteLine("Indicar el nombre del platillo");
                misNotas[noPlatillos].nombre = Console.ReadLine();
                Console.WriteLine("Indicar el precio");
                misNotas[noPlatillos].precio = Double.Parse(Console.ReadLine());
                noPlatillos++;
                Console.WriteLine("Desea continuar? si=s no=n");
            } while (noPlatillos < misNotas.Length && Console.ReadKey().KeyChar != 'n');
        }
        public void Cuenta()
        {
            Double acumula = 0;
            for (int control = 0; control < noPlatillos; control++)
            {
                Console.WriteLine("Producto {0} precio {1}:", misNotas[control].nombre, misNotas[control].precio);
                acumula += misNotas[control].precio;
            }

            Console.WriteLine("El total es {0}:", acumula);
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int cuantos;
            Mesero maria;
            Console.WriteLine("Indicar cuantos platillos tendra de capacidad");
            cuantos = int.Parse(Console.ReadLine());
            maria = new Mesero(cuantos);
            maria.Captura();
            maria.Pedido();
            maria.Cuenta();
        }
    }
}
