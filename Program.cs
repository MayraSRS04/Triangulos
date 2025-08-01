using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VERIFICADOR DE TRIANGULOS\n");

            Console.Write("INGRESE EL LADO A DEL TRIANGULO: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("INGRESE EL LADO B DEL TRIANGULO: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("INGRESE EL LADO C DEL TRIANGULO: ");
            double c = double.Parse(Console.ReadLine());

            if (a == b && b == c)
                Console.WriteLine("\nEL TRIANGULO ES EQUILATERO");
            else if (a == b || a == c || b == c)
                Console.WriteLine("\nEL TRIANGULO ES ISOSCELES");
            else
                Console.WriteLine("\nEL TRIANGULO ES ESCALENO");
        }
    }
}
