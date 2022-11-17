// Ejercicio 03

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Ejercicio_03
    {
        static void Main(string[] args)
        {
            Fachada fachada = new Fachada();
            var consultas = fachada.nuevaSala("consultas",new StrategyFIFO());
            var urgencias = fachada.nuevaSala("urgencias",new StrategyTriaje());
            string opcion;
            do
            {
                Console.Clear();
                opcion = null;
                Console.Write("Ingrese una opción (C: Siguiente Paciente de Sala Consultas,U: Siguiente Paciente de la Sala de Urgencias, S para Salir):");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "C": var pacienteC = consultas.atenderPaciente();
                        Console.WriteLine("DATOS DEL PACIENTE");
                        Console.WriteLine("Nombre: "+pacienteC.Nombre);
                        Console.WriteLine("Apellido: "+pacienteC.Apellido);
                        Console.WriteLine("DNI: "+pacienteC.DNI);
                        Console.WriteLine("Prioridad: "+pacienteC.OrdenPrioridad);
                        Console.WriteLine("Fecha y Hora de Llegada: "+pacienteC.Llegada);
                        Console.WriteLine();
                        Console.WriteLine("Cantidad de pacientes restantes de la sala de consultas: ");
                        Console.WriteLine(consultas.cantidadPacientesRestantes());
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case "U":
                        var pacienteU = urgencias.atenderPaciente();
                        Console.WriteLine("DATOS DEL PACIENTE");
                        Console.WriteLine("Nombre: " + pacienteU.Nombre);
                        Console.WriteLine("Apellido: " + pacienteU.Apellido);
                        Console.WriteLine("DNI: " + pacienteU.DNI);
                        Console.WriteLine("Prioridad: " + pacienteU.OrdenPrioridad);
                        Console.WriteLine();
                        Console.Write("Cantidad de pacientes restantes de la sala de urgencias: ");
                        Console.WriteLine(urgencias.cantidadPacientesRestantes());
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;
                }
            }
            while (opcion != "S");
        }
    }
}