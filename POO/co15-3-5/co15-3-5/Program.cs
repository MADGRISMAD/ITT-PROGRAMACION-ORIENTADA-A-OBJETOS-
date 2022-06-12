using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co15_03_5
{
    public class Password
    {
        String password;
        int contador;
        public void Captura()
        {
            int opc = 0;
            do
            {
                try
                {
                    opc++;
                    if (opc == 4)
                    {
                        opc = 4;
                        throw new System.FormatException();
                    }
                    else
                        Console.WriteLine("Indicar la Contraseña: ");
                    password = Console.ReadLine();
                    contador = password.Length;
                    if (contador > 10)
                    {
                        opc = 4;
                        Console.WriteLine("Contraseña correcta");
                    }

                    else
                        throw new Exception();

                }
                catch (System.FormatException)
                {
                    Console.Beep();
                    Console.WriteLine("Has superado el numero de intentos");
                }
                catch (Exception)
                {
                    Console.WriteLine("La Caracteres no son los correctos");
                }
            } while (opc != 4);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Password contra = new Password();
            contra.Captura();
            Console.ReadLine();
        }
    }
}