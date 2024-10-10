using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo tri;
            tri = new Triangulo();

            Console.WriteLine("Digite o primeiro valor:    ");
            tri.setLado1(double.Parse(Console.ReadLine()));


            Console.WriteLine("Digite o segundo valor:     ");
            tri.setLado2(double.Parse(Console.ReadLine()));


            Console.WriteLine("Digite o terceiro valor:    ");
            tri.setLado3(double.Parse(Console.ReadLine()));

            tri.compararTriangulo();

            Console.WriteLine(tri.getTriangulo());





        }
    }
}
