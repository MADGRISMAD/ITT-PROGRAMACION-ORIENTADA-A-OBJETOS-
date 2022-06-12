using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co15_2_4
{
    interface Generica
    {
        String Ver();
        char Capta(int x, int y, String mensaje);
        char Menu(int x, int y);
    }
    public class Restaurante : Generica
    {
        protected String producto;
        protected double precio;
        protected int cantidad;
        public double Total()
        {
            return precio * cantidad;
        }
        public string Ver()
        {

            return "producto:" + producto +
                   "\nprecio:" + precio +
                   "\ncanntidad:" + cantidad +
                   "total:" + Total();
        }
        public char Capta(int x, int y, String mensaje)
        {
            Console.SetCursorPosition(x, y); Console.WriteLine(mensaje);
            return Console.ReadKey().KeyChar;
        }
        public char Capta(int x, int y, String mensaje, Boolean capturar)
        {
            if (capturar)
                return Capta(x, y, mensaje);
            else
            {
                Console.SetCursorPosition(x, y); Console.WriteLine(mensaje);
            }
            return ' ';


        }
        public char Menu(int x, int y)
        {
            Capta(x, y++, "pizzeria grodiños", false);
            Capta(x, y++, "1 solicitud de pizzzas", false);
            Capta(x, y++, "2 pagar", false);
            return Capta(x, y++, "desea continuar? S/N");


        }
        public void Proceso()
        {
            char opc;
            do
            {
                Console.Clear();
                opc = Menu(10, 10);
                switch (opc)
                {
                    case '1':
                        Capta(10, 10, "indicar el precio de la pizza", false);
                        precio = double.Parse(Console.ReadLine());
                        Capta(10, 11, "indicar el cantidad de la pizza", false);
                        cantidad = int.Parse(Console.ReadLine());
                        break;
                    case '2':
                        Capta(1, 1, Ver(), false);
                        Console.ReadKey();
                        break;


                }

            } while (opc != 'N');
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Restaurante pizzeria = new Restaurante();
            pizzeria.Proceso();

        }
    }
}
