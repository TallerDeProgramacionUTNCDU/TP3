using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    public class EncriptadorCesar:Encriptador
    {
        private int iDesplazamiento;
        public EncriptadorCesar(int pDesplazamiento) : base("César")
        {
            iDesplazamiento = pDesplazamiento;
        }
        public override String Encriptar(String pCadena)
        {
            var caracteres = pCadena.ToCharArray();
            for (int i = 0; i < caracteres.Length; i++)
            {
                for (int k = 0; k < iDesplazamiento; k++)
                {
                    caracteres[i] = caracterSiguiente(caracteres[i]);
                }      
            }
            return new String(caracteres);
        }
        public Char caracterSiguiente(Char pCaracter)
        { 
                if (pCaracter == 'z')
                    pCaracter = 'a';
                else if (pCaracter == 'Z')
                    pCaracter = 'A';
                else
                    pCaracter = (char)(((int)pCaracter) + 1);
            return pCaracter;
        }
        public Char caracterAnterior(Char pCaracter)
        {
            if (pCaracter == 'a')
                pCaracter = 'z';
            else if (pCaracter == 'A')
                pCaracter = 'Z';

            else
                pCaracter = (char)(((int)pCaracter) - 1);
            return pCaracter;
        }
        public override String Desencriptar(String pCadena)
        {
            var caracteres = pCadena.ToCharArray();
            for (int i = 0; i < caracteres.Length; i++)
            {
                for (int k = 0; k < iDesplazamiento; k++)
                {
                    caracteres[i] = caracterAnterior(caracteres[i]);
                }
            }
            return new String(caracteres);
        }
    }
}
