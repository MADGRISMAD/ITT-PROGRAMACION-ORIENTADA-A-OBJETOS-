using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Edades
    {
        int edad;
        int año;
        public void Captura()
        {
            try
            {
                Console.WriteLine("Ingrese año de nacimiento");
                año = int.Parse(Console.ReadLine());
                edad = 2021 - año;
                if (edad >= 18 && edad <= 65)
                {
                    Console.WriteLine("Tu edad es: {0}", edad);
                    Console.WriteLine("Puedes continuar trabajando");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Tu edad es: {0}", edad);
                Console.WriteLine("No puedes trabajar si no tienes entre 18 y 65 años");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Edades edad = new Edades();
            edad.Captura();
            Console.ReadKey();
        }
    }
}