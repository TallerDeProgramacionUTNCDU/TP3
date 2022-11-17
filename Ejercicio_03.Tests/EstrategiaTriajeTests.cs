using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class EstrategiaTriajeTests
    {
        [TestCase()]
        public void SiguientePaciente_MismaPrioridad_Success()
        {
            var estrategia = new StrategyTriaje();
            var fecha1 = DateTime.ParseExact("01/01/2023 00:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var fecha2 = DateTime.ParseExact("01/01/2023 00:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var pacienteVerde1 = new Paciente("Marcos", "Sastre", "1234", Paciente.Prioridad.verde, fecha1);
            var pacienteVerde2 = new Paciente("Juan", "Cobol", "5678", Paciente.Prioridad.verde, fecha2);
            Paciente[] pacientes = new Paciente[2];
            pacientes[0] = pacienteVerde1;
            pacientes[1] = pacienteVerde2;

            var siguiente = estrategia.obtenerSiguientePaciente(pacientes);

            Assert.AreEqual(pacienteVerde1, siguiente);
        }
        [TestCase()]
        public void SiguientePaciente_NormalSituation_Success()
        {
            var estrategia = new StrategyTriaje();
            var fecha1 = DateTime.ParseExact("01/01/2023 00:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var fecha2 = DateTime.ParseExact("01/01/2023 00:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var fecha3 = DateTime.ParseExact("01/01/2023 00:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var paciente1 = new Paciente("Marcos", "Sastre", "1234", Paciente.Prioridad.verde, fecha1);
            var paciente2 = new Paciente("Juan", "Cobol", "5678", Paciente.Prioridad.rojo, fecha2);
            var paciente3 = new Paciente("Carlos", "Moreno", "9012", Paciente.Prioridad.azul, fecha3);
            Paciente[] pacientes = new Paciente[3];
            pacientes[0] = paciente1;
            pacientes[1] = paciente2;
            pacientes[2] = paciente3;

            var siguiente = estrategia.obtenerSiguientePaciente(pacientes);

            Assert.AreEqual(paciente2, siguiente);
        }
        [TestCase()]
        public void SiguientePaciente_OneRemaining_Success()
        {
            var estrategia = new StrategyTriaje();
            var fecha = DateTime.ParseExact("01/01/2023 00:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var ultimoPaciente = new Paciente("Marcos", "Sastre", "1234", Paciente.Prioridad.amarillo, fecha);
            Paciente[] pacientes = new Paciente[1];
            pacientes[0] = ultimoPaciente;

            var siguiente = estrategia.obtenerSiguientePaciente(pacientes);

            Assert.AreEqual(ultimoPaciente, siguiente);
        }
    }
}
