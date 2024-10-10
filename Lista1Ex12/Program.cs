using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulos tri;
            tri = new Triangulos();

            Console.Write("Digite o valor do lado 1:  ");
            tri.setLado1(int.Parse(Console.ReadLine()));

            Console.Write("Digite o valor do lado 2:  ");
            tri.setLado2(int.Parse(Console.ReadLine()));

            Console.Write("Digite o valor do lado 3:  ");
            tri.setLado3(int.Parse(Console.ReadLine()));

            tri.compararTriangulo();

            Console.WriteLine("Os valores representam um triângulo:  {0}", tri.getTipo());



        }
    }
}
