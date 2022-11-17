namespace Ejercicio_04_Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class Encriptadores_Tests
    {
        [TestCase("hola")]
        public void EncriptadorAes_EncryptAndDecrypt_Success(string pCadena)
        {
            var encriptador = new Ejercicio_04.EncriptadorAES(0);
            var palabraEncriptada = encriptador.Encriptar(pCadena);
            var palabraDesencriptada = encriptador.Desencriptar(palabraEncriptada);

            Assert.AreEqual(pCadena, palabraDesencriptada);
        }

        [TestCase("hola",10)]
        public void EncriptadorCesar_EncryptAndDecrypt_Success(string pCadena, int pDesplazamiento)
        {
            var encriptador = new Ejercicio_04.EncriptadorCesar(pDesplazamiento);
            var palabraEncriptada = encriptador.Encriptar(pCadena);
            var palabraDesencriptada = encriptador.Desencriptar(palabraEncriptada);

            Assert.AreEqual(pCadena, palabraDesencriptada);
        }

        [TestCase("hola")]
        public void EncriptadorDES_EncryptAndDecrypt_Success(string pCadena)
        {
            var encriptador = new Ejercicio_04.EncriptadorDES(0);
            var palabraEncriptada = encriptador.Encriptar(pCadena);
            var palabraDesencriptada = encriptador.Desencriptar(palabraEncriptada);

            Assert.AreEqual(pCadena, palabraDesencriptada);
        }

        [TestCase("hola")]
        public void EncriptadorTripleDES_EncryptAndDecrypt_Success(string pCadena)
        {
            var encriptador = new Ejercicio_04.EncriptadorTripleDES(0);
            var palabraEncriptada = encriptador.Encriptar(pCadena);
            var palabraDesencriptada = encriptador.Desencriptar(palabraEncriptada);

            Assert.AreEqual(pCadena, palabraDesencriptada);
        }
        [TestCase("hola")]
        public void EncriptadorNulo_EncryptAndDecrypt_Success(string pCadena)
        {
            var encriptador = new Ejercicio_04.EncriptadorNulo(0);
            var palabraEncriptada = encriptador.Encriptar(pCadena);
            var palabraDesencriptada = encriptador.Desencriptar(palabraEncriptada);

            Assert.AreEqual(pCadena, palabraDesencriptada);
        }
    }
}