using System;
using System.Collections.Generic;
using System.Text;

namespace PerfectPaint.Objetos
{
    class Lienzo
    {
        public double ancho { get; set; }
        public double alto { get; set; }
        public int backgroundColor { get; set; }

        List<Figura> figurasDibujadas = new List<Figura>();

        public void aniadirFigura(Figura figura)
        {
            figurasDibujadas.Add(figura);
        }

        public int cantidadDibujos()
        {
            return figurasDibujadas.Count;
        }
    }
}
