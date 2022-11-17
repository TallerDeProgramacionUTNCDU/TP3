using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    public interface iEncriptador
    {
        String Encriptar(String pCadena);
        String Desencriptar(String pCadena);
    }
}
