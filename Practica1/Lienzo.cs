using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Lienzo
    {
        public string Nombre { get; set; }
        public double Alto { get; set; }
        public double Ancho { get; set; }
        public List<Figura> Figuras = new List<Figura>();

    }
}
