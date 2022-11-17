using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    public class EncriptadorNulo:Encriptador
    {
        public EncriptadorNulo(int pDesplazamiento) : base("Nulo") { }
        public override String Encriptar(String pCadena) { return pCadena; }
        public override String Desencriptar(String pCadena) { return pCadena; }
    }
}
