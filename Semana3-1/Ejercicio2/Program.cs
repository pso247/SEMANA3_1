using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vpiso;
            double valquiler, vcochera;
            const double cascensor = 100;
            const double ccochera = 45;
            string nombre, alquiler, cochera,piso;
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el alquiler:");
            alquiler = Console.ReadLine();
            Console.WriteLine("En que piso vive?");
            piso=Console.ReadLine();
            Console.WriteLine("Tiene cochera?");
            cochera = Console.ReadLine();

            valquiler = double.Parse(alquiler);
            vpiso = int.Parse(piso);

            if (vpiso >= 3 && vpiso <= 8 && cochera == "si")
            {
                valquiler = valquiler + cascensor + ccochera;
                Console.WriteLine(nombre + ", su alquiler es de " + valquiler);
            }
            else if (vpiso<3 && cochera == "si")
            {
                valquiler = valquiler + ccochera;
                Console.WriteLine(nombre + ", su alquiler es de " + valquiler);
            }
            else if (vpiso > 8)
            {
                Console.WriteLine(nombre + ", El edidificio solo es de 8 piso");

            }
            else if (vpiso >= 3 && vpiso <= 8 && cochera == "no")
            {
                valquiler = valquiler + cascensor;
                Console.WriteLine(nombre + ", su alquiler es de " + valquiler);
            }
           
            else
            {
                Console.WriteLine(nombre + ", su alquiler es de " + valquiler);
            }
        }

        
    }
}
