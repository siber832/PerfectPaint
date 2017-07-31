using PerfectPaint.Objetos;
using System;

namespace PerfectPaint
{
    class Program
    {
        static Lienzo lienzo = new Lienzo();
        static void Main(string[] args)
        {
            Console.Write("Define un ancho del lienzo: ");
            lienzo.ancho = Double.Parse(Console.ReadLine());
            Console.Write("Define un alto del lienzo: ");
            lienzo.alto = Double.Parse(Console.ReadLine());

            dibujaAlgo();

            Console.ReadLine();
        }

        static void dibujaAlgo()
        {
           
            Figura f;
            Console.WriteLine("¿Que quieres dibujar?\n 1 Circulo \n !1 Cuadrado");
            var numeroInsertado = Console.ReadLine();
            
            if(numeroInsertado.Equals("1"))
            {
                f = new Circulo();
            }
            else
            {
                f = new Cuadrado();
            }

            f.dibujar();
            lienzo.aniadirFigura(f);

            Console.WriteLine("Ahora hay " + lienzo.cantidadDibujos() + " figuras en el lienzo");
        }

        
    }
}