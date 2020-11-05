using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Circulo:Figura
    {
        public string Nombre { get; set; }
        public double PosX { get; set; }
        public double PosY { get; set; }
        public double Radio { get; set; }
        public Circulo(string nombre, double radio)
        {
            Nombre = nombre;
            Radio = radio;
            PosX = 0;
            PosY = 0;
            CalcularAreaCirculo();
        }
        public Circulo(string nombre, double radio, double posx, double posy)
        {
            Nombre = nombre;
            Radio = radio;
            PosX = posx;
            PosY = posy;
            CalcularAreaCirculo();
        }
        public double CalcularAreaCirculo()
        {
            double areaCirculo = Math.PI*(Radio*Radio);
            return areaCirculo;
        }
    }
}
