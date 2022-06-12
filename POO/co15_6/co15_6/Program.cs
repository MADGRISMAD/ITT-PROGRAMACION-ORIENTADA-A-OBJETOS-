using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co15_6
{
    public class escuela
    {
        public int nosalones;

    }
    class Program
    {
        static void prueba1()
        {
            int a = 15;
            int b;
            b = a;
            b = 7;

            Console.WriteLine("el valor de a es {0} y el de b es {1}", a, b);

        }
        static void prueba2()
        {
            escuela a;
            escuela b;
            a = new escuela();
            a.nosalones = 8;
            b = a;
            b.nosalones = 20;
            Console.WriteLine("el valor de a es {0} y el de b es {1}", a.nosalones, b.nosalones);
            a.nosalones = 25;
            Console.WriteLine("el valor de a es {0} y el de b es {1}", a.nosalones, b.nosalones);
        }
        static void Main(string[] args)
        {
            prueba1();
            prueba2();
            Console.ReadKey();
        }
    }
}