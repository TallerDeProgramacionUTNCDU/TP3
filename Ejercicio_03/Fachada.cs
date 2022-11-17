using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    public class Fachada
    {
        public Sala nuevaSala(string pNombre,StrategyAtencion pEstrategia)
        {
            var nuevaSala = new Sala(pNombre, pEstrategia);
            var fecha1 = DateTime.ParseExact("01/01/2023 00:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var fecha2 = DateTime.ParseExact("01/01/2023 00:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var fecha3 = DateTime.ParseExact("01/01/2023 00:13:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var fecha4 = DateTime.ParseExact("01/01/2023 00:22:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var fecha5 = DateTime.ParseExact("01/01/2023 01:10:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var fecha6 = DateTime.ParseExact("31/12/2022 23:45:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var fecha7 = DateTime.ParseExact("01/01/2023 02:01:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var fecha8 = DateTime.ParseExact("01/01/2023 02:10:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var fecha9 = DateTime.ParseExact("01/01/2023 02:10:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var fecha10 = DateTime.ParseExact("01/01/2023 07:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var paciente1 = new Paciente("Marcos", "Sastre", "1234", Paciente.Prioridad.verde,fecha1);
            var paciente2 = new Paciente("Juan", "Cobol", "5678", Paciente.Prioridad.rojo, fecha2);
            var paciente3 = new Paciente("Paula", "González", "13141", Paciente.Prioridad.rojo,fecha3 );
            var paciente4 = new Paciente("Juan", "Martínez", "8768", Paciente.Prioridad.amarillo, fecha4);
            var paciente5 = new Paciente("Jorge", "Larrivey", "23426", Paciente.Prioridad.anaranjado,fecha5);
            var paciente6 = new Paciente("Manuel", "Gómez", "079078", Paciente.Prioridad.azul,fecha6);
            var paciente7 = new Paciente("Gastón", "Giménez", "670769", Paciente.Prioridad.verde,fecha7);
            var paciente8 = new Paciente("Augusto", "Rodríguez", "6897698", Paciente.Prioridad.rojo,fecha8);
            var paciente9 = new Paciente("Valentino", "Ricchieri", "68976", Paciente.Prioridad.rojo,fecha9);
            var paciente10 = new Paciente("Nicolás", "Bertinat", "6879769", Paciente.Prioridad.azul,fecha10);
            nuevaSala.pacientes[0] = paciente1;
            nuevaSala.pacientes[1] = paciente2;
            nuevaSala.pacientes[2] = paciente3;
            nuevaSala.pacientes[3] = paciente4;
            nuevaSala.pacientes[4] = paciente5;
            nuevaSala.pacientes[5] = paciente6;
            nuevaSala.pacientes[6] = paciente7;
            nuevaSala.pacientes[7] = paciente8;
            nuevaSala.pacientes[8] = paciente9;
            nuevaSala.pacientes[9] = paciente10;
            return nuevaSala;
        }
        public Paciente antenderPaciente(Sala pSala)
        {
            return pSala.atenderPaciente();
        }
        public int cantidadPacientesSala(Sala pSala)
        {
            return pSala.cantidadPacientesRestantes();
        }
    }
}
