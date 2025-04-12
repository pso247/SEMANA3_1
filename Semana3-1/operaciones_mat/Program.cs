using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaciones_mat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1,n2,resultado;
            string num1, num2,operacion;
            Console.WriteLine("Ingrese el primer número: ");
            num1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo número: ");
            num2 = Console.ReadLine();  
            Console.WriteLine("Ingrese la operación: ");
            operacion=Console.ReadLine();

            n1 = double.Parse(num1);
            n2 = double.Parse(num2);


            switch (operacion)
            {
                case "+" : 
                    resultado=n1 + n2;
                    Console.WriteLine("La suma es: " + resultado);
                    break;
                case "-":
                    resultado = n1 - n2;
                    Console.WriteLine("La resta es: " + resultado);
                    break;
                case "*":
                    resultado = n1 * n2;
                    Console.WriteLine("La multiplicación es: " + resultado);
                    break;
                case "/":
                    if (n2 != 0)
                    {
                        resultado = n1 / n2;
                        Console.WriteLine("La división es: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("Error: División por cero no permitida.");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
