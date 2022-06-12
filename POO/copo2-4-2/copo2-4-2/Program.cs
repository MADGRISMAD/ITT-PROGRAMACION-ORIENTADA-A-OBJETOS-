using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cop2_4_2
{
    public class calculador
    {
        private int valorA;
        private int valorB;
        private int valorfinal;
        public void actualiza(int b, int c)
        {
            valorA = b; valorB = c;
        }

        public static calculador operator *(calculador b, calculador c)
        {
            calculador r = new calculador();
            r.valorfinal = b.valorA * c.valorB;
            return r;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            calculador resultado, a, b;
            a = new calculador();
            a.actualiza(7, 5);
            

        }
    }
}