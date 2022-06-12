
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace co15_10_2
{
    public class triangulo
    {
        private double altura, abajo;
        public triangulo(double altura, double abajo)
        {
            Actualiza(altura, abajo);
        }
        public void Actualiza(double altura, double abajo)
        {
            this.altura = altura;
            this.abajo = abajo;
        }
        public string ver()
        {
            return "el area es " + area() + " la base es " + abajo + " altura es " + altura;
        }
        public double area()
        {
            return (altura * abajo) / 2;
        }
        public static triangulo operator +(triangulo r1, triangulo r2)
        {
            triangulo resultado;
            resultado = new triangulo(r1.altura, r1.abajo);
            resultado.altura = resultado.altura + r2.altura;
            resultado.abajo = resultado.abajo + r2.abajo;
            return resultado;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "tringulo";
            /*--------------------------------------------*/
            triangulo tringulop;
            tringulop = new triangulo(5, 10);
            Console.WriteLine("en el triangulo {0}", tringulop.ver());
            Console.ReadKey();
        }
    }

}
