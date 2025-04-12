using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuestionario4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string e;
            Console.WriteLine("Ingrese la edad del niño: ");
            e= Console.ReadLine();
            edad = int.Parse(e);

            switch (edad)
            {
                case 4:
                case 5:
                    Console.WriteLine("Ir al nido");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Ir al colegio");
                    break;
                default:
                    Console.WriteLine("Edad no válida para este programa.");
                    break;
            }
        }
    }
}
