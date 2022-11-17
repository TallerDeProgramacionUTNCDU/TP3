using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    public class Fachada
    {
        public FabricaEncriptadores nuevaFabrica()
        {
           return FabricaEncriptadores.nuevaFabricaEncriptadores();
        }
        public Encriptador establecerEncriptador(FabricaEncriptadores pFabrica,String pNombre, int pDesplazamiento)
        {
            return pFabrica.GetEncriptador(pNombre, pDesplazamiento);
        }
        public String Encriptar(Encriptador pEncriptador, String pPalabra)
        {
            return pEncriptador.Encriptar(pPalabra);
        }
        public String Desencriptar(Encriptador pEncriptador, String pPalabra)
        {
            return pEncriptador.Desencriptar(pPalabra);
        }

    }
}
