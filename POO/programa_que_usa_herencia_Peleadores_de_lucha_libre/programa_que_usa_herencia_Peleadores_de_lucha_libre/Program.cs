using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_que_usa_herencia_Peleadores_de_lucha_libre
{
    public class Caracteristicas
    {
        public string nombre;
        public double fuerza;
        public double velocidad;
        public double altura;
        public double nopeleador;
        public Caracteristicas()
        {

            nombre = "sin nombre";
            fuerza = 5;
            velocidad = 5;
            altura = 5;
            nopeleador = 0;
        }
        public virtual void Caracteristicasdepeleador(string nombre, double fuerza, double velocidad, double altura)
        {

            Console.WriteLine("las caracteristicas son\nnombre:{0}\nfuerza: {1}\nvelocidad: {2}\naltura: {3}\n\n", nombre, fuerza, velocidad, altura);

        }

    }

    public class peleadoresprime : Caracteristicas
    {
        public override void Caracteristicasdepeleador(string nombre, double fuerza, double velocidad, double altura)
        {
            Console.WriteLine("las caracteristicas son\nnombre:{0}\nfuerza: {1}\nvelocidad: {2}\naltura: {3}\n\n", nombre, fuerza, velocidad, altura);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejemplo de herencia";
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;


            Caracteristicas peleador1 = new Caracteristicas();
            Caracteristicas peleador2 = new Caracteristicas();
            Caracteristicas peleador3 = new Caracteristicas();
            Caracteristicas peleador4 = new Caracteristicas();

            peleadoresprime peleadorprime1 = new peleadoresprime();
            peleadoresprime peleadorprime2 = new peleadoresprime();
            peleadoresprime peleadorprime3 = new peleadoresprime();
            peleadoresprime peleadorprime4 = new peleadoresprime();


            peleador1.Caracteristicasdepeleador("juan", 7, 4, 5);
            peleador2.Caracteristicasdepeleador("pedro", 2, 5, 9);
            peleador3.Caracteristicasdepeleador("babodecarteldesanta", 14, 11, 2);
            peleador4.Caracteristicasdepeleador("mi tio pacheco", 7, 2, 15);

            peleadorprime1.Caracteristicasdepeleador("juan prime", 70, 80, 90);
            peleadorprime2.Caracteristicasdepeleador("pedro prime", 125, 40, 50);
            peleadorprime3.Caracteristicasdepeleador("babodecareldesanta prime", 60, 85, 90);
            peleadorprime4.Caracteristicasdepeleador("mi tio pacheco prime", 70, 90, 100);



            Console.ReadLine();
        }
    }
}
