using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //input output

namespace co15_1b_6
{
    public class Archivo
    {
        private string nombreArchivo;
        public Archivo(string nombrefisico)
        {
            nombreArchivo = nombrefisico;
        }
        public void EscribeDoc()
        {


            FileStream archivo;
            string texto;

            archivo = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.Write);


            StreamWriter escribirArchivo = new StreamWriter(archivo);
            Console.WriteLine("capturar un texto. para continuar enter escribir un . y un enter");

            do
            {
                texto = Console.ReadLine();
                if (texto != ".") ;
                escribirArchivo.WriteLine(texto);
            } while (texto != ".");


            escribirArchivo.Close();
        }
        public void Leer()
        {
            //string nombreArchivo = "temp.txt";
            FileStream archivo;
            archivo = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
            StreamReader leyendo = new StreamReader(archivo);
            while (leyendo.Peek() > -1) //-1 oidica fin del archivo
                Console.WriteLine(leyendo.ReadLine());
            leyendo.Close();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Archivo archivo = new Archivo("tempo.txt");
            archivo.EscribeDoc();
            archivo.Leer();
            Console.ReadLine();
        }
    }
}