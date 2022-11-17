using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    public class FabricaEncriptadores
    {
        private static FabricaEncriptadores cInstancia=null;
        private Encriptador encriptador;
        private FabricaEncriptadores() { }
        public static FabricaEncriptadores nuevaFabricaEncriptadores()
        {
            if (cInstancia == null) { cInstancia = new FabricaEncriptadores(); }
            return cInstancia;
        }
        public  Encriptador GetEncriptador(String pNombre,int pDesplazamiento)
        {
            encriptador = new EncriptadorNulo(pDesplazamiento);
            switch (pNombre) {
                case "César":
                        encriptador = new EncriptadorCesar(pDesplazamiento);
                        break;
                case "AES":
                        encriptador = new EncriptadorAES(pDesplazamiento);
                        break;
                case "DES":
                        encriptador = new EncriptadorDES(pDesplazamiento);
                    break;
                case "TRIPLE DES":
                    encriptador = new EncriptadorTripleDES(pDesplazamiento);
                    break;
            }
            return encriptador;
        }
        public FabricaEncriptadores Instancia
        {
            get { return cInstancia; }
            set { cInstancia = value; }
        }
    }
}

