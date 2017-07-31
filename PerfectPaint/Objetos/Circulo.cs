using System;
using System.Collections.Generic;
using System.Text;

namespace PerfectPaint.Objetos
{
    class Circulo:Figura
    {
        public double radio { get; set; }

        public override void dibujar()
        {
            base.dibujar();
            Console.WriteLine("Circulo");
        }
    }
}
