using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado qd = new Quadrado();

            Console.WriteLine("Digite o valor do lado: ");
            qd.setLado(int.Parse(Console.ReadLine()));

            qd.calcularArea();

            Console.WriteLine("A área do quadrado é: {0}", qd.getArea());
        }
    }
}
