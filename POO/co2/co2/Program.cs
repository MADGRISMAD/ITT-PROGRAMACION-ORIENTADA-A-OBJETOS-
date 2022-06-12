using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ALV_v4
{
    public class DatosIMC
    {
        String[] diagnostico = { "Muy Delgado", "Normal", "Pre Obeso", "Sobre Peso", "Obesidad", "Obesidad 2", "Obesidad Morbida", "Obesidad Extrema" };
        Double[,] valores = { { 10, 18.4 }, { 18.5, 24.9 }, { 25, 26.9 }, { 27, 29.9 }, { 30, 34.9 }, { 35, 39.9 }, { 40, 40.99 }, { 50, 100 } };

        public String verDiagnostico(double imc)
        {

            int ciclo = 0;
            do
            {
                if (imc >= valores[ciclo, 0] && imc <= valores[ciclo, 1])
                    return diagnostico[ciclo];
                ciclo++;


            } while (ciclo < diagnostico.Length);
            return "fuera de rango";


        }
        public String VerTablaIMC()
        {

            for (int ciclo = 0; ciclo < diagnostico.Length; ciclo++)
            {
                Console.WriteLine("\n{0}\t\t\t", diagnostico[ciclo]);
                Console.WriteLine("{0} {1} ", valores[ciclo, 0], valores[ciclo, 1]);
            }

            return "";


        }
    }
    public class IMC
    {
        private Double estatura;
        private int peso;

        public void Actualiza(Double estatura)
        {
            this.estatura = estatura;
        }

        public void Actualiza(int peso)
        {
            this.peso = peso;
        }
        public void Actualiza(double peso, int estatura)
        {
            Actualiza(estatura); Actualiza(peso);
        }

        public Double Calculo()
        {
            return peso / Math.Pow(estatura, 2);
        }
        public String Diagnostico()
        {
            DatosIMC iMC = new DatosIMC();

            return iMC.verDiagnostico(Calculo());
        }
    }
    public class indiceMC
    {
        IMC imc;
        public indiceMC()
        {
            Captura();
        }
        public void Captura()
        {
            double estatura = 0.0;
            int peso;
            imc = new IMC();
            do
            {
                Console.WriteLine("indicar la estatura en metros");
                estatura = double.Parse(Console.ReadLine());
                Console.WriteLine("indicar el peso en kilogramos");
                peso = int.Parse(Console.ReadLine());
                imc.Actualiza(peso);
                imc.Actualiza(estatura);
                Console.WriteLine(imc.Diagnostico());
                Console.WriteLine("desea capturar otro s/n");

            } while (Console.ReadKey().KeyChar == 's');
        }
        class Program
        {

            static void Main(string[] args)
            {
                indiceMC imc = new indiceMC();





                Console.ReadLine();
            }
        }
    }
}