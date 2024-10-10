using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex10
{
    internal class Terreno
    {
        private double b;
        private double h;
        private double area;
        private string maior;

        public void setBase(double b)
        { this.b = b; }

        public void setAltura(double h)
        { this.h = h; }

        public double getBase()
        { return this.b; }

        public double getAltura()
        { return this.h; }

        public double getArea()
        { return this.area; }

        public string getMaiorExtenso()
        { return this.maior; }

        public void calcularArea()
        { this.area = this.b * this.h; 
     
            if (area > 100)
            {
                this.maior = "Terreno Grande";
            }

            else
            {
                this.maior = "Terreno Pequeno";
                }
            }
        }





    }

