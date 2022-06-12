using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //input output

namespace co15_1_6
{
    public class Archivo
    {
        public void EscribeDoc()
        {
            //nombre del archivo fisico o real
            string nombreArchivo = "temp.txt";
            FileStream archivo;//nombre logico del archivo
            //este nombre logico se utiliza en el programa para acceder a los datos del archivo
            archivo = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.Write);
            //abre el archivo y lo crea si no existe. el acceso al mismo sera para escribir datos
            StreamWriter escribirArchivo = new StreamWriter(archivo);
            escribirArchivo.WriteLine("mi primer renglon");
            escribirArchivo.WriteLine("mi primer renglon");
            escribirArchivo.WriteLine("mi primer renglon");
            escribirArchivo.WriteLine("mi primer renglon");
            escribirArchivo.WriteLine("mi primer renglon");
            escribirArchivo.WriteLine("mi primer renglon");
            escribirArchivo.Close();
        }
        public void Leer()
        {
            string nombreArchivo = "temp.txt";
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
            Archivo archivo = new Archivo();
            archivo.EscribeDoc();
            archivo.Leer();
            Console.ReadKey();
        }
    }
}