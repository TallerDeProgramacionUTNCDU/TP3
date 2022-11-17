using System;
using Xunit;
using Ejercicio_02;

namespace Ej1.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Circulo tr = new Circulo(new Punto(0, 0), 1);
            Assert.Equal(3.14, tr.CalcularArea(), 2);
        }
    }
}
