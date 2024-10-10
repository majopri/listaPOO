using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex9
{
    internal class Maior
    {
        private double v1;
        private double v2;
        private double mv;
        private string maior;

        public void setValor1(double v1)
        { this.v1 = v1; }

        public void setValor2(double v2)
        { this.v2 = v2; }

        public double getValor1()
        { return this.v1; }

        public double getValor2()
        { return this.v2; }

        public double getMaior()
        { return this.mv; }

        public string getMaiorExtenso()
        { return this.maior; }

        public void calcularMaior()

        {
            if (v1 == v2)
            {
                this.mv = this.v1;
                this.maior = "iguais";
            }

            else
            {
                if (v1 > v2)
                {
                    this.mv = this.v1;
                    this.maior = "primeiro";
                }
                else
                {
                    this.mv = this.v2;
                    this.maior = "segundo";
                }
            }
        }

    }

}

