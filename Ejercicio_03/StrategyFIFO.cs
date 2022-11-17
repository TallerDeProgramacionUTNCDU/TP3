using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    public class StrategyFIFO : StrategyAtencion
    {
        public Paciente obtenerSiguientePaciente(Paciente[] pListaPacientes)
        {
            pListaPacientes =pListaPacientes.OrderBy(x =>  x.Llegada).ToArray();
            return pListaPacientes[0];
        }
        public Paciente[] actualizarListaPacientes(Paciente[] pListaPacientes)
        {
            pListaPacientes =pListaPacientes.OrderBy(x => x.Llegada).ToArray();
            var pAtendido = pListaPacientes[0];
            return pListaPacientes.Where(val => val != pAtendido).ToArray();
        }
    }
}
