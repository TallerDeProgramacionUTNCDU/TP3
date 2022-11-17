using System.Globalization;

namespace Ejercicio_03.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class EstrategiasFIFOTests
    {
        [TestCase()]
        public void SiguientePaciente_MismoDateTime_Success()
        {
            var estrategia = new StrategyFIFO();
            var fecha = DateTime.ParseExact("01/01/2023 00:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var paciente1 = new Paciente("Marcos", "Sastre", "1234", Paciente.Prioridad.verde, fecha);
            var paciente2 = new Paciente("Juan", "Cobol", "5678", Paciente.Prioridad.rojo, fecha);
            Paciente[] pacientes= new Paciente[2];
            pacientes[0] = paciente1;
            pacientes[1] = paciente2;

            var siguiente = estrategia.obtenerSiguientePaciente(pacientes);

            Assert.AreEqual(paciente1, siguiente);
        }
        [TestCase()]
        public void SiguientePaciente_OneSecondDiff_Success()
        {
            var estrategia = new StrategyFIFO();
            var fechaUnSegundoDespues = DateTime.ParseExact("01/01/2023 00:25:01", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var fecha = DateTime.ParseExact("01/01/2023 00:25:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var pacienteLlegoDespues = new Paciente("Marcos", "Sastre", "1234", Paciente.Prioridad.verde, fechaUnSegundoDespues);
            var paciente = new Paciente("Juan", "Cobol", "5678", Paciente.Prioridad.rojo, fecha);
            Paciente[] pacientes = new Paciente[2];
            pacientes[0] = pacienteLlegoDespues;
            pacientes[1] = paciente;

            var siguiente = estrategia.obtenerSiguientePaciente(pacientes);

            Assert.AreEqual(paciente, siguiente);
        }
        [TestCase()]
        public void SiguientePaciente_NormalSituation_Success()
        {
            var estrategia = new StrategyFIFO();
            var fecha1 = DateTime.ParseExact("01/01/2023 00:25:01", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var fecha2 = DateTime.ParseExact("01/01/2023 01:35:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var fecha3 = DateTime.ParseExact("31/12/2022 23:59:59", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var paciente1 = new Paciente("Marcos", "Sastre", "1234", Paciente.Prioridad.verde, fecha1);
            var paciente2 = new Paciente("Juan", "Cobol", "5678", Paciente.Prioridad.rojo, fecha2);
            var paciente3 = new Paciente("José", "Morales", "9012", Paciente.Prioridad.azul, fecha3);
            Paciente[] pacientes = new Paciente[3];
            pacientes[0] = paciente1;
            pacientes[1] = paciente2;
            pacientes[2] = paciente3;

            var siguiente = estrategia.obtenerSiguientePaciente(pacientes);

            Assert.AreEqual(paciente3,siguiente);
        }

        [TestCase()]
        public void SiguientePaciente_OneRemaining_Success()
        {
            var estrategia = new StrategyFIFO();
            var fechaUltimoPaciente = DateTime.ParseExact("01/01/2023 00:25:01", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var ultimoPaciente = new Paciente("Marcos", "Sastre", "1234", Paciente.Prioridad.verde, fechaUltimoPaciente);

            Paciente[] pacientes = new Paciente[1];
            pacientes[0] = ultimoPaciente;

            var siguiente = estrategia.obtenerSiguientePaciente(pacientes);

            Assert.AreEqual(ultimoPaciente, siguiente);
        }
    }
}