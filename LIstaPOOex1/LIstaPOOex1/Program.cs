using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIstaPOOex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret;
            ret = new Retangulo();

            Console.WriteLine("Digite o valor da base do retâgulo: ");
            ret.setBase(int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o valor da altura do retângulo: ");
            ret.setAltura(int.Parse(Console.ReadLine()));

            ret.calcularArea();

            Console.WriteLine("Área do retângulo: {0}", ret.getArea());
            
        }
    }
}
