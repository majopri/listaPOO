using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex7
{
    internal class Dolar
    {
        private double d;
        private double c;
        private double r;

        public void setDolar(double d)
            { this.d = d; }

        public void setCotacao(double c)
            { this.c = c; }

        public double getDolar()
            { return this.d; }

        public double getCotacao()
            { return this.c; }

        public double getReais()
        { return this.r; }

        public void calcularReais()
        { this.r = this.d * this.c; }


    }
}
