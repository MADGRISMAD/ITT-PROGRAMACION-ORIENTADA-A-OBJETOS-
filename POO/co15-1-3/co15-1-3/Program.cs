using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co151_3
{
    public class Base
    {
        private int privada;
        protected int protegida;
        public int publica;
        public Base()
        {
            protegida = 10;
            privada = 1;

        }
        public void Publico()
        {
            Privado("desde el publico");
        }
        protected void protegido()
        {
            Privado("desde el protegido");
        }
        private void Privado(string mensaje)
        {
            Console.WriteLine("{0} variable privado {1} protegida{2} publica {3}", mensaje, privada, protegida, publica);
        }
    }
    public class Derivada : Base
    {
        public void derivapublico()
        {
            //privada =9; marca error por que es provada y pertenece a la clase base\
            protegida = 200;
            publica = 7;
            Publico();
            protegido();

        }
        public void Metodo()
        {
            protegida = 5;
            base.protegida = 15;
            Console.WriteLine("protegida{0} en derivada", protegida);
            Console.WriteLine("protegida{0} en base", base.protegida);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Derivada derivada;
            derivada = new Derivada();
            derivada.Publico();
            derivada.publica = 7;
            derivada.derivapublico();
            Console.ReadKey();
        }
    }
}
