using System;

namespace Ejercicio_02
{
    public class Circulo : FiguraGeometrica
    {
        private double iRadio;
        Punto iCentro;

        public double Radio
        {
            get
            {
                return iRadio;

            }
        }

        public Punto Centro
        {
            get
            {
                return this.iCentro;
            }
        }
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public Circulo(Punto pCentro, double pRadio)
        {
            this.iCentro = pCentro;
            this.iRadio = pRadio;
        }

        public Circulo(double pX, double pY, double pRadio)
        {
            this.iRadio = pRadio;
            this.iCentro = new Punto(pX, pY);
        }
    }
}