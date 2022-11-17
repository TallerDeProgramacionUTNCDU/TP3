using System;

namespace Ejercicio_02
{
    public class Triangulo : FiguraGeometrica
    {
        Punto iPunto1;
        Punto iPunto2;
        Punto iPunto3;

        public Punto Punto1
        {
            get
            {
                return this.iPunto1;
            }
        }
        public Punto Punto2

        {
            get
            {
                return this.iPunto2;
            }
        }

        public Punto Punto3
        {
            get
            {
                return this.iPunto3;
            }
        }

        public override double CalcularArea()
        {
            double LadoA = iPunto1.CalcularDistanciaDesde(iPunto2);
            double LadoB = iPunto2.CalcularDistanciaDesde(iPunto3);
            double LadoC = iPunto3.CalcularDistanciaDesde(iPunto1);
            double semiperimetro = CalcularPerimetro() / 2;
            return Math.Sqrt(semiperimetro * (semiperimetro - LadoA) * (semiperimetro - LadoB) * (semiperimetro - LadoC));
        }

        public override double CalcularPerimetro()
        {
            double LadoA = iPunto1.CalcularDistanciaDesde(iPunto2);
            double LadoB = iPunto2.CalcularDistanciaDesde(iPunto3);
            double LadoC = iPunto3.CalcularDistanciaDesde(iPunto1);
            return LadoA + LadoB + LadoC;
        }

        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            iPunto1 = pPunto1;
            iPunto2 = pPunto2;
            iPunto3 = pPunto3;
        }


    }
}