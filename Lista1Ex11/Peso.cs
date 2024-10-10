using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex11
{
    internal class Peso
    {
        private double p;
        private double h;
        private double pi;
        private string i;

        public void setPeso(double p)
        { this.p = p; }

        public void setAltura(double h)
        { this.h = h; }

        public double getPeso() 
        { return this.p; }  

        public double getAltura()
        { return this.h; }

        public double getPesoideal() 
        { return this.pi; }    

        public string getIdeal() 
        { return this.i; }

        public void calcularPeso()
        { this.pi = this.p/Math.Pow(h,2);
        
        if (this.pi < 20) {  this.i = "Abaixo do Peso"; }

            if (this.pi <= 25) { this.i = "Peso ideal"; }

            else { this.i = "Acima do Peso"; }
        
        
        }
    }
}
