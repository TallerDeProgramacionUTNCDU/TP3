using System;

namespace Ejercicio_02
{
    public class Punto
    {
        double iX;

        double iY;

        public Punto(double pX, double pY)
        {
            this.iX = pX;
            this.iY = pY;
        }

        public double X
        {
            get { return this.iX; }
        }

        public double Y
        {
            get { return this.iY; }
        }

        public double CalcularDistanciaDesde(Punto pPunto)
        {
            return Math.Sqrt(Math.Pow(pPunto.X - this.iX, 2) + Math.Pow(pPunto.Y - this.iY, 2));
        }
    }
}