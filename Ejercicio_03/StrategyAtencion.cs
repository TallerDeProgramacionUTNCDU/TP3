using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    public interface StrategyAtencion
    {
        Paciente obtenerSiguientePaciente(Paciente[] listaPacientes);
        Paciente[] actualizarListaPacientes(Paciente[] listaPacientes);
    }
}
