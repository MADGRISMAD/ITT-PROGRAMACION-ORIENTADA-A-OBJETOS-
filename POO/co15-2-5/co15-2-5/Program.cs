using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Co_15_2_5
{
    public class Prueba
    {
        public void P1A()
        {
            int a = int.Parse(Console.ReadLine());
        }
        public void P1B()
        {
            int a;
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("capturar solo numeros");
            }
            //System.FormatException

        }
        public void P1C()
        {
            int a;
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch (System.FormatException mensaje)
            {
                Console.WriteLine(mensaje);
            }
            //System.FormatException

        }
        public void P1D()
        {
            int a;
            Boolean error = false;
            do
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    error = false;
                
                

                
error = false;
                }
                catch
                {
                    error = true;
                    Console.WriteLine("capturar solo numeros");
                    Console.Beep(1900, 100);
                    Console.Beep(659, 125); Console.Beep(659, 125); Console.Beep(659, 125);
                }
                //System.FormatException
            } while (error);

        }
        public Double Divide(int a, int b)
        {
            return a / b;
        }
        public double DivideB(int a, int b)
        {
            double m = 0;
            try
            {
                m = a / b;
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("no se debe dividir entre 0");
            }
            return m;
        }
        public double DivideC(int a, int b)
        {
            double m = 0;
            try
            {
                m = a / b;
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("no se debe dividir entre 0");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("solo numeros");
            }
            return m;
        }
        public void Llamadivide()
        {
            int a = 9, b = 0;
            Console.WriteLine("{0}/{1}={2}", a, b, DivideC(a, b));
        }
        

public void Corrida()
        {
            P1A();
            P1B();
            P1C();
            P1D();
            Llamadivide();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Prueba P = new Prueba();
            P.Llamadivide();
            Console.ReadLine();
        }
    }
}