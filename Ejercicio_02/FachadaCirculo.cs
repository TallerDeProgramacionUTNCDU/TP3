using System;

namespace Ejercicio_02
{
    class FachadaCirculo
    {
        public double CalcularArea(double x, double y, double Radio)
        {
            Circulo Circ = new Circulo(x, y, Radio);
            return Circ.CalcularArea();
        }

        public double CalcularPerimetro(double x, double y, double Radio)
        {
            Circulo Circ = new Circulo(x, y, Radio);
            return Circ.CalcularPerimetro();
        }
    }
}

