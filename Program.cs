using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Terreno t;
            t = new Terreno();

            Console.WriteLine(" Digite o valor da base");
            t.setBase(double.Parse(Console.ReadLine()));

            Console.WriteLine(" Digite o valor da altura");
            t.setAltura(double.Parse(Console.ReadLine()));

            t.calcularArea();
            Console.WriteLine("Area é: {0} - {1}", t.getArea(), t.getMaiorExtenso());




        }
    }
}
