using System;
using System.Collections.Generic;
using System.Text;

namespace PerfectPaint.Objetos
{
    class Cuadrado:Figura
    {
        public String color { get; set; }
        public int xx1 { get; set; }
        public int xx2 { get; set; }
        public int yy1 { get; set; }
        public int yy2 { get; set; }

        public override void dibujar()
        {
            base.dibujar();
            Console.WriteLine("Cuadrado");
        }

    }
}
