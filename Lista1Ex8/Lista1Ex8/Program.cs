using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maior m;
            m = new Maior();

            Console.WriteLine(" Digite o primeiro valor:  ");
            m.setValor1(double.Parse(Console.ReadLine()));

            Console.WriteLine(" Digite o segundo valor:  ");
            m.setValor2(double.Parse(Console.ReadLine()));

            m.calcularMaior();
            Console.WriteLine("O maior valor é:  ");
            Console.WriteLine(m.getMaior());



        }
    }
}
