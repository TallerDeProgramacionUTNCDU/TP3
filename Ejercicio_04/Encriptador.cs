using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    public abstract class Encriptador:iEncriptador
    {
        private String iNombre;
        public abstract String Encriptar(String pCadena);
        public abstract String Desencriptar(String pCadena);
        public Encriptador(String pNombre)
        {
            iNombre = pNombre;
        }
        public String Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }
    }
}
