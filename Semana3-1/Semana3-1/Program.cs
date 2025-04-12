using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vpromedio, vpension;
            const double d1 = 0.2;
            const double d2 = 0.1;
            const double d3 = 0.05;
            string nombre, pension, promedio;
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su pension:");
            pension = Console.ReadLine();
            Console.WriteLine("Ingrese su promedio:");
            promedio = Console.ReadLine();

            vpromedio = double.Parse(promedio);
            vpension = double.Parse(pension);

            if (vpromedio >= 19 && vpromedio <= 20)
            {
                vpension= vpension - (vpension * d1);

                Console.WriteLine(nombre + ", su pensión tiene un descuento del 20% total a pagar " + vpension);
            }
            else if (vpromedio >= 18 && vpromedio < 19)
            {
                vpension = vpension - (vpension * d2);
                Console.WriteLine(nombre + ", su pensión tiene un descuento del 10% total a pagar " + vpension);
            }
            else if (vpromedio >= 17 && vpromedio < 18)
            {
                vpension = vpension - (vpension * d3);
                Console.WriteLine(nombre+", su pensión tiene un descuento del 5% total a pagar " + vpension);
            }
            else if (vpromedio >= 0 && vpromedio < 17)
            {
                Console.WriteLine(nombre + ", su promedio no tiene descuento, total a pagar" + vpension);
            }
            else
            {
                Console.WriteLine("Error: El promedio debe estar entre 0 y 20.");
            }
        }
    }
}

                
            
        
    

