using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    public class StrategyTriaje : StrategyAtencion
    {
        public Paciente obtenerSiguientePaciente(Paciente[] pListaPacientes)
        {
            var ordenado = pListaPacientes.OrderBy(x => x.OrdenPrioridad).ToArray();
            return ordenado[0];
        }
        public Paciente[] actualizarListaPacientes(Paciente[] pListaPacientes)
        {
            var ordenado = pListaPacientes.OrderBy(x => x.OrdenPrioridad).ToArray();
            var pAtendido = ordenado[0];
            return pListaPacientes.Where(val => val != pAtendido).ToArray();
        }
    }
}
