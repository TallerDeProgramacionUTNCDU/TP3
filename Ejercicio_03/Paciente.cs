using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    public class Paciente
    {
        private string iNombre;
        private string iApellido;
        private string iDNI;
        private int iOrdenPrioridad;
        private DateTime iLlegada;
        public enum Prioridad { rojo = 1, anaranjado, amarillo, verde, azul};
        public Paciente(string pNombre, string pApellido, string pDNI, Prioridad pPrioridad,DateTime pLlegada)
         {
            iNombre= pNombre;
            iApellido= pApellido;
            iDNI=pDNI;
            iLlegada=pLlegada;
            switch (pPrioridad) {
                case Prioridad.rojo:
                    iOrdenPrioridad=1 ;
                    break;
                case Prioridad.anaranjado:
                    iOrdenPrioridad = 2;
                    break;
                case Prioridad.amarillo:
                    iOrdenPrioridad = 3;
                    break;
                case Prioridad.verde:
                    iOrdenPrioridad = 4;
                    break;
                case Prioridad.azul:
                    iOrdenPrioridad = 5;
                    break;
            }
         }
        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }
        public string Apellido
        {
            get { return this.iApellido; }
            set { this.iApellido = value; }
        }

        public string DNI
        {
            get { return this.iDNI; }
            set { this.iDNI = value; }
        }
        public int OrdenPrioridad
        {
            get { return this.iOrdenPrioridad; }
            set { this.iOrdenPrioridad = value; }
        }
        public DateTime Llegada
        {
            get { return this.iLlegada; }
            set { this.iLlegada = value; }
        }

    }
}
