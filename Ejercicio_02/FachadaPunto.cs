using System;

namespace Ejercicio_02
{
    class FachadaPunto
    {
        public double DistanciaEntreDosPuntos(double x1, double y1, double x2, double y2)
        {
            Punto p1 = new Punto(x1, y1);
            Punto p2 = new Punto(x2, y2);

            return p1.CalcularDistanciaDesde(p2);
        }
    }
}