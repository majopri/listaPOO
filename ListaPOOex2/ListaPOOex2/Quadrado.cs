using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOex2
{
    internal class Quadrado
    {
        private int l;
        private double area;
        public void setLado(int l)

            { this.l = l; }

        public int getLado()
            { return this.l; }

        public double getArea()
            { return this.area; }

        public void calcularArea()
        {
            this.area = Math.Pow(l, 2); }
        
        }

    }
