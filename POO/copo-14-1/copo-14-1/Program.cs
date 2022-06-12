using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace copo14_1_cuadrado
{
    public class cuadrilatero
    {
        private double lado;
        public void actualizar(double lado)
        {
            this.lado = lado;
        }
        public double Lado()
        {
            return lado;
        }
        public double diametro()
        {
            return lado * 4;
        }
        public double area()
        {
            return lado * lado;
        }
        public string ver()
        {
            return "los datos del cuadrado son" + "\nel lado del cuadrado es: " + lado + "\nel diametro del cuadrado es: " + diametro() + "\nel area del cuadrado es: " + area();
        }




    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "CoPo14-1_CUADRADO";
            /* ---------------------------------------------*/
            cuadrilatero objeto;
            objeto = new cuadrilatero();
            double lado;
            Console.WriteLine("indica el lado de la figura");
            lado = double.Parse(Console.ReadLine());
            objeto.actualizar(lado);
            Console.WriteLine(objeto.ver());
            Console.ReadKey();





        }
    }
}
