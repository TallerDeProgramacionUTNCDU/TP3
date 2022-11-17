using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Text.Json.Serialization.Metadata;

namespace Ejercicio_04
{
    public class EncriptadorAES : Encriptador
    {
        public Aes myAes;
        private static readonly int tamanyoClave = 32;
        private static readonly int tamanyoVector = 16;
        private static readonly string Clave = "Juan Sin Miedo";
        private static readonly string Vector = "Estoes una prueba837723";
        public static byte[] key = UTF8Encoding.UTF8.GetBytes(Clave);
        public static byte[] iv = UTF8Encoding.UTF8.GetBytes(Vector);

        public EncriptadorAES(int pDesplazamiento) : base("AES") 
        {
            myAes = Aes.Create();
            //iv=myAes.IV;
            //key=myAes.Key;
        }
        public override String Encriptar(String pCadena)
        {
            //byte[] result = EncryptStringToBytes_Aes(pCadena, key, iv);
            //return Convert.ToBase64String(result);
            return CifradoTexto(pCadena);
        }
        public override String Desencriptar(String pCadena)
        {
            //byte[] cifrado = Convert.FromBase64String(pCadena);
            // var result = DecryptStringFromBytes_Aes(cifrado, key,iv);
            //return result;
            return DescifradoTexto(pCadena);
        }
        public static string CifradoTexto(String txtPlano)

        {

            Array.Resize(ref key, tamanyoClave);
            Array.Resize(ref iv, tamanyoVector);

            // se instancia el Rijndael

            Rijndael RijndaelAlg = Rijndael.Create();

            // se establece cifrado

            MemoryStream memoryStream = new MemoryStream();

            // se crea el flujo de datos de cifrado

            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                RijndaelAlg.CreateEncryptor(key, iv),
                CryptoStreamMode.Write);

            // se obtine la información a cifrar

            byte[] txtPlanoBytes = UTF8Encoding.UTF8.GetBytes(txtPlano);

            // se cifran los datos

            cryptoStream.Write(txtPlanoBytes, 0, txtPlanoBytes.Length);

            cryptoStream.FlushFinalBlock();

            // se obtinen los datos cifrados

            byte[] cipherMessageBytes = memoryStream.ToArray();

            // se cierra todo

            memoryStream.Close();
            cryptoStream.Close();

            // Se devuelve la cadena cifrada

            return Convert.ToBase64String(cipherMessageBytes);
        }
        public static string DescifradoTexto(String txtCifrado)
        {

            Array.Resize(ref key, tamanyoClave);
            Array.Resize(ref iv, tamanyoVector);

            // se obtienen los bytes para el cifrado

            byte[] cipherTextBytes = Convert.FromBase64String(txtCifrado);

            // se almacenan los datos descifrados

            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
 
			// se crea una instancia del Rijndael			
 
			Rijndael RijndaelAlg = Rijndael.Create();

            // se crean los datos cifrados

            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);

            // se descifran los datos

            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                RijndaelAlg.CreateDecryptor(key, iv),
                CryptoStreamMode.Read);

            // se obtienen datos descifrados

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);

            // se cierra todo

            memoryStream.Close();
            cryptoStream.Close();

            // se devuelve los datos descifrados

            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        }

        //In the following lines is the previous code used for AES Encryption an Decryption, it doesn't work as intended. While using this methods it drops an error: 'System.Security.Cryptography.CryptographicException: 'The input data is not a complete block.'. The code used previously works fine for this case, the code below could be fixed and used, however it would end up really similar to the first case. 
        //I'm leaving this part of the code as a reminder of how the situation worked out.

        /*
        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            Array.Resize(ref key, tamanyoClave);
            Array.Resize(ref iv, tamanyoVector);
            // Create an Aes object
            // with the specified key and IV.
            Aes aesAlg = Aes.Create();
            
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                aesAlg.Padding=PaddingMode.None;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                MemoryStream msEncrypt = new MemoryStream();

                CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);
                        byte[] plaintextB = UTF8Encoding.UTF8.GetBytes(plainText);
                        csEncrypt.Write(plaintextB, 0, plaintextB.Length);
                        csEncrypt.FlushFinalBlock();
                        /*using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();*/
                        /*encrypted = msEncrypt.ToArray();
                        msEncrypt.Close();
                        csEncrypt.Close();
            return encrypted;
        }

        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            Array.Resize(ref key, tamanyoClave);
            Array.Resize(ref iv, tamanyoVector);

            // Create an Aes object
            // with the specified key and IV.
            Aes aesAlg = Aes.Create();
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                aesAlg.Padding=PaddingMode.None;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            // Create the streams used for decryption.
            MemoryStream msDecrypt = new MemoryStream(cipherText);
            CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
            /*(StreamReader srDecrypt = new StreamReader(csDecrypt));
                       {

                           // Read the decrypted bytes from the decrypting stream
                           // and place them in a string.
                           plaintext = srDecrypt.ReadToEnd();
                       }*/
           /* int decryptedByteCount = csDecrypt.Read(cipherText, 0, cipherText.Length);
            msDecrypt.Close();
            csDecrypt.Close();

            return Encoding.UTF8.GetString(cipherText, 0, decryptedByteCount);
        }*/

    }
}
