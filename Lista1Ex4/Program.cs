using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo tri;
            tri = new Triangulo();

            Console.WriteLine("digite o valor da base: ");
            tri.setBase(int.Parse(Console.ReadLine()));

            Console.WriteLine("digite o valor da altura: ");
            tri.setAltura(int.Parse(Console.ReadLine()));

            tri.calcularArea();

            Console.WriteLine("o valor da area do triangulo e: ");
            Console.WriteLine(tri.getArea());





        }
    }
}
