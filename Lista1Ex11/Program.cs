using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Peso pe;
            pe = new Peso();

            Console.Write("Digite o valor do peso:    ");
            pe.setPeso(double.Parse(Console.ReadLine()));

            Console.WriteLine(" Digite o valor da sua altura:   ");
            pe.setAltura(double.Parse(Console.ReadLine()));


            pe.calcularPeso();
            Console.WriteLine("Esse é o valor do seu peso: {0} - {1}", pe.getPesoideal(), pe.getIdeal());



        }
    }
}
