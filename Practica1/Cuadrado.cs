using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Cuadrado:Figura
    {
        public string Nombre { get; set; }
        public double PosX { get; set; }
        public double PosY { get; set; }
        public double Lado { get; set; }
        public double CalcularAreaCuadrado()
        {
            double areaCuadrado = Lado * Lado;
            return areaCuadrado;
        }
    }
}
