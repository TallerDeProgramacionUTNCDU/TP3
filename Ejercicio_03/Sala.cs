using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    public class Sala
    {
        private string iNombreSala;
        public Paciente[] pacientes = new Paciente[10];
        private StrategyAtencion estrategia;
        public Sala(string pNombreSala, StrategyAtencion pEstrategia)
        {
            this.iNombreSala=pNombreSala;
            this.estrategia = pEstrategia;
        }
        public Paciente atenderPaciente()
        {
            var encontrado = estrategia.obtenerSiguientePaciente(pacientes);
            actualizarListaPacientes();
            return encontrado;
        }
        public void actualizarListaPacientes()
        {
            pacientes= (estrategia.actualizarListaPacientes(pacientes));
        }
        public string NombreSala

        { get { return this.iNombreSala; }
            set { this.iNombreSala = value; }
        }
        public int cantidadPacientesRestantes()
        {
            return pacientes.Length;
        }
    }
}
