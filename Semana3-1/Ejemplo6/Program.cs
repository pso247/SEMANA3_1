using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int e;
            string mes;
            Console.WriteLine("Ingrese el mes: ");
            mes = Console.ReadLine();

            e = int.Parse(mes);

            switch(e)
            {
                case 1:
                case 2: 
                case 3:
                    Console.WriteLine("Verano");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Otoño");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Invierno");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Primavera");
                    break;
                default:
                    Console.WriteLine("Mes no válido");
                    break;

            }
            Console.ReadKey();

        }
    }
}
