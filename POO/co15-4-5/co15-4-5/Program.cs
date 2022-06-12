
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co15_04_5
{ // funcion que solo capture edades y funcion que solo capture en un rango de edades
    public class Numeros
    { // Hacer una funcion que solo permita capturar numeros decimales
        // Hacer una expecion en la que se capture un password y este sea mayor a 10 letras
        public int DivideE()
        {
            int a, b, t = 0;
            Console.WriteLine("Indicar dos numeros enteros a dividir y enter despues" + "De capturar un umero y despues el otro");
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                t = a / b;
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Numeros diferentes de cero");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Solo numeros diferentes de cero");
            }
            /*catch (System.FormatException e)
            {
                Console.Beep(1500, 1500); Console.WriteLine(e); Console.Beep();
                Console.WriteLine("Kill C: *.*");*/
            finally
            {
                Console.WriteLine("Proceso concluido");
            }
            return t;
        }
        public Double DivideD()
        {
            Double a, b, t = 0;
            Console.WriteLine("Indicar dos numeros enteros a dividir y enter despues" + "De capturar un umero y despues el otro");
            try
            {
                a = Double.Parse(Console.ReadLine());
                b = Double.Parse(Console.ReadLine());
                if (b != 0)
                    t = a / b;
                else
                    throw new System.DivideByZeroException();
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Numeros diferentes de <<cero>>");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Solo numeros diferentes de cero");
            }
            finally
            {
                Console.WriteLine("Proceso concluido");
            }
            return t;
        }
        public Double Decimales(String texto, Boolean letrero)
        {
            Double numero = 0;
            int entero = 0;
            Double resultado;
            Boolean error;
            if (letrero)
                Console.WriteLine(texto);
            do
            {
                error = false;
                try
                {
                    numero = Double.Parse(Console.ReadLine());
                    entero = (int)numero;
                    resultado = entero - numero;
                    if (resultado == 0)
                    {
                        numero = 0;// Lanzando una excepcion

                        throw new System.FormatException();
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Solo numeros con decimales");
                    error = true;
                }
            } while (error);
            return numero;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Numeros nums;
            nums = new Numeros();
            Double a;
            //Double a = nums.Decimales("Inidcar un numero con decimales", true);
            a = nums.DivideD();
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}