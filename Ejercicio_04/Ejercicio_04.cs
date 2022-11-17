// Ejercicio 04

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Ejercicio_04
    {
        static void Main(string[] args)
        {
            Fachada fachada = new Fachada();
            var fabrica = fachada.nuevaFabrica();
            string encriptacion;
           string opcion;
            int desplazamiento;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese una opción (E para Encriptar una palabra, D para Desencriptar una palabra, S para Salir): ");
                opcion = Console.ReadLine();
                Console.WriteLine();
                switch (opcion)
                {
                    case "E":
                        Console.Write("Escriba el Algoritmo de Encriptación a Utilizar (César, AES, Nulo, DES, TRIPLE DES): ");
                        encriptacion = Console.ReadLine();
                        if (encriptacion == "César") { Console.Write("Ingrese el Desplazamiento: "); desplazamiento = Int32.Parse(Console.ReadLine()); }
                        else { desplazamiento = 0; }
                        Console.Write("Ingrese la palabra a encriptar: ");
                        string palabraE = Console.ReadLine();
                        var encriptadorE = fachada.establecerEncriptador(fabrica, encriptacion, desplazamiento);
                        var resultadoE = fachada.Encriptar(encriptadorE, palabraE);
                        Console.WriteLine("La palabra encriptada es: " + resultadoE);
                        Console.ReadKey();
                        break;
                    case "D":
                        Console.Write("Escriba el Algoritmo de Desencriptación a Utilizar (César, AES, Nulo, DES, TRIPLE DES): ");
                        encriptacion = Console.ReadLine();
                        if (encriptacion == "César") { Console.Write("Ingrese el Desplazamiento: "); desplazamiento = Int32.Parse(Console.ReadLine()); }
                        else { desplazamiento = 0; }
                        Console.Write("Ingrese la palabra a Desencriptar: ");
                        string palabraD = Console.ReadLine();
                        var encriptadorD = fachada.establecerEncriptador(fabrica, encriptacion, desplazamiento);
                        var resultadoD = fachada.Desencriptar(encriptadorD, palabraD);
                        Console.WriteLine("La palabra desencriptada es: " + resultadoD);
                        Console.ReadKey();
                        break;
                }
            }
            while (opcion != "S");
        }
    }
}
