using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co15_03_5
{
    public class Edades
    {
        int edad;
        public void Captura()
        {
            try
            {
                Console.WriteLine("Indicar la edad");
                edad = int.Parse(Console.ReadLine());
                if (edad <= 60)
                    Console.WriteLine("La edad es: {0}", edad);
                else
                    throw new Exception();
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Escribir la edad en numero");
            }
            catch (Exception)
            {
                Console.WriteLine("La edad esta fuera del rango permitido");
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Edades edad = new Edades();
            edad.Captura();
            Console.ReadLine();
        }
    }
}