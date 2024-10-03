using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado2 qd=new Quadrado2();

            Console.WriteLine("Digite o valor da diagonal: ");
            qd.setDiagonal(int.Parse(Console.ReadLine()));

            qd.calcularArea();

            Console.WriteLine("A área do quadrado é: {0}", qd.getArea());
        }
    }
}
