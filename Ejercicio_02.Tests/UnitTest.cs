using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class UnitTest
    {
        [TestCase()]
        public void Test1()
        {
            Circulo tr = new Circulo(new Punto(0, 0), 1);
            Assert.AreEqual(3.14, tr.CalcularArea(), 2);
        }
    }
}
