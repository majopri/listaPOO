using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex13
{
    internal class Triangulo
    {
        private double a;
        private double b;
        private double c;
        private double h;
        private double cateto1;
        private double cateto2;
        private string tri;

        public void setLado1(double a) { this.a = a; }
        public void setLado2(double b) { this.b = b; }
        public void setLado3(double c) { this.c = c; }

        public double getLado1() { return this.a; }

        public double getLado2() { return this.b; }

        public double getLado3() { return this.c; }

        public double getHipotenusa() { return this.h; }

        public double getCateto1() { return this.cateto1; }

        public double getCateto2() { return this.cateto2; }

        public string getTriangulo() { return this.tri; }

        public void compararTriangulo()
        {
            if (this.a > this.b && this.a > this.c)
            {
                this.h = this.a;
                this.cateto1 = b;
                this.cateto2 = c;
            }
            else if (this.b > this.a && this.b > this.c)
            {
                this.h = this.b;
                this.cateto1 = a;
                this.cateto2 = c;

            }
            else
            {
                this.h = this.c;
                this.cateto1 = a;
                this.cateto2 = b;

            }
            if (Math.Pow(this.h, 2) == (Math.Pow(cateto1, 2)) + (Math.Pow(cateto2, 2))) 
            {
                this.tri = "Os valores formam um triangulo retângulo";
            }
            else
            {
                this.tri = "Os valores não formam um triângulo retângulo";
            }


        }


    }
}

            













        

        














   
