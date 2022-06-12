using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copo14_1
{
    public class circulo
    {
        private double radio;
        public void actualizar(double radio)
        {
            this.radio = radio; //this permite diferenciar la clase en su propiedad de radio

        }
        public Double Radio()
        {
            return radio;
        }
        public double Diametro()
        {
            return radio * 2;

        }
        public double Area()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
        public double Circunferencia()
        {
            return Math.PI * Diámetro();
        }

        private double Diámetro()
        {
            throw new NotImplementedException();
        }

        public string ver()
        {
            return "los datos del círculo son \n" + "el radio es: " + radio + "\n el diámetro es " + Diametro() + "\nel area es " + Area() + "\n circunferencia " + Circunferencia();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CoPo14-1";
            Console.ForegroundColor = ConsoleColor.Red;
            circulo objeto;//declaramos el objeto
            objeto = new circulo();//creamos el objeto
            Double radio;
            Console.WriteLine("indicar el radio");
            radio = double.Parse(Console.ReadLine());
            objeto.actualizar(radio);
            Console.WriteLine(objeto.ver());
            Console.ReadKey();




        }
    }
}
