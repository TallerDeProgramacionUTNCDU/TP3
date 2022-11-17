using System;

namespace Ejercicio_02
{
    class FachadaTriangulo
    {
        public double CalcularArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            Punto p1 = new Punto(x1, y1);
            Punto p2 = new Punto(x2, y2);
            Punto p3 = new Punto(x3, y3);

            Triangulo tr = new Triangulo(p1, p2, p3);
            return tr.CalcularArea();
        }

        public double CalcularPerimetro(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            Punto p1 = new Punto(x1, y1);
            Punto p2 = new Punto(x2, y2);
            Punto p3 = new Punto(x3, y3);

            Triangulo tr = new Triangulo(p1, p2, p3);
            return tr.CalcularPerimetro();
        }
    }
}