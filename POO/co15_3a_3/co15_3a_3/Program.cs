using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co15_3a_3
{
    public class contenedor
    {
        protected double nivel;
        protected double maximo;

        public contenedor(double nivel, double maximo)
        {
            Iniciar(nivel, maximo);
        }
        public contenedor()
        {

        }

        public void Iniciar(double nivel, double maximo)
        {
            this.nivel = nivel;
            this.maximo = maximo;
        }
        public void iniciar(contenedor objeto)
        {
            Iniciar(objeto.nivel, objeto.maximo);

        }

        public double Depositar(double cantidad)
        {
            if (cantidad + nivel <= maximo)
                nivel += cantidad;
            else
            {
                double derrame = maximo - (cantidad + nivel);
                nivel = maximo;
                return derrame;
            }
            return nivel;

        }
        public double Retirar(double cantidad)
        {
            if (nivel - cantidad >= 0)

                nivel -= cantidad;

            else
                nivel = 0;
            return nivel;
        }
    }
    public class Cuenta : contenedor
    {
        protected string cuenta;
        protected string cliente;
        public void Iniciar(string cuenta, string cliente, double nivel, double maximo)
        {
            this.cuenta = cuenta;
            this.cliente = cliente;
            Iniciar(nivel, maximo);
            /* this.nivel = nivel;
             this.maximo = maximo;*/
        }
        public string ver()
        {
            return "cliente" + cliente + "\nno de cuenta" + cuenta + "\nsaldo: " + nivel;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Cuenta banorte = new Cuenta();
            banorte.Iniciar("22545", "juan penas", 1000, 200000);
            Console.WriteLine(banorte.ver());
            Console.ReadLine();
        }
    }
}
