using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co3_15
{
    public class boton
    {
        private Boolean on;
        public string push()
        {
            if (on == true)
                on = false;//aqui se modifica el estado del objeto
            else
                on = true;
            return on ? "on" : "off"; //aqui esta mostradon el esdado del objeto
        }
    }
    class Program
    {
        static private boton palanca;
        public Program()// cosntructor
        {
            palanca = new boton();//creando objeto
        }
        static void presionar()
        {
            Console.WriteLine(palanca.push());

        }

        static void Main(string[] args)
        {
            Console.Title = "progrmaa";
            palanca = new boton();

            presionar();
            presionar();
            presionar();
            presionar();
            Console.ReadLine();


        }
    }
}
