using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuestionario2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ENCENDIDO = 1;
            const int APAGADO = 0;
            Console.WriteLine("Ingrese Letra");

            int estado = 1;
            
            switch (estado)
            {
                case ENCENDIDO:
                    Console.WriteLine("ENCENDIDO");
                    break;
                case APAGADO:
                    Console.WriteLine("APAGADO");
                    break;
                default:
                    Console.WriteLine("DESCONOCIDO");
                    break;
            }
            Console.ReadKey();
        }
    }
}
