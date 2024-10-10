using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolar valor;
            valor = new Dolar();

            Console.WriteLine(" Digite o valor da cotação do dólar:   ");
            valor.setCotacao(double.Parse(Console.ReadLine()));

            Console.WriteLine("Digite a quatidade de dólares:  ");
            valor.setDolar(double.Parse(Console.ReadLine()));

            valor.calcularReais();

            Console.Write(" O valor em Reais é:   ");
            Console.WriteLine(valor.getReais());

        }
    }
}
