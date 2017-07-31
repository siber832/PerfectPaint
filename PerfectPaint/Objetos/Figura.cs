using System;
using System.Collections.Generic;
using System.Text;

namespace PerfectPaint.Objetos
{
    abstract class Figura
    {
        String color;
        int x1, x2, y1, y2;

        public virtual void dibujar()
        {
            //TODO:
            Console.Write("Voy a dibujar un " );
        }
    }
}
