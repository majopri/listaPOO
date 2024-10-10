using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex12
{
    internal class Triangulos
    {
        private int a;
        private int b;
        private int c;
        private string t;

        public void setLado1(int a) { this.a = a; }

        public void setLado2(int b) {  this.b = b; }

        public void setLado3(int c) {  this.c = c; }

        public int getLado1() { return this.a;}

        public int getLado2() { return this.b;}

        public int getLado3() { return this.c;} 

        public string getTipo() { return this.t; }  

        public void compararTriangulo()
        {
            if (this.a + this.b > this.c)
                if (this.a + this.c > this.b)
                    if (this.b + this.c > this.a)
                        if (this.a == this.b)
                            if (this.a == this.c)
                                this.t = "Equilátero";
                            else
                                this.t = "Isósceles";
                        else
                            if (this.b == this.c)
                            this.t = "Isósceles";
                        else
                            if (this.a == this.c)
                            this.t = "Isósceles";
                        else
                            this.t = "Escaleno";
                    else
                        this.t = "Não forma triângulo";
                else
                    this.t = "Não forma triângulo";
            else
                this.t = "Não forma triângulo";

 
        
        
        }






    }
}
