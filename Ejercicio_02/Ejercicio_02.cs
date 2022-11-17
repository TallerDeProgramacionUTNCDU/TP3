using System;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio_02
{
    class Ejercicio_02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la figura: \n1. Circulo. \n2. Triangulo. \n3. Punto");
            int figura = int.Parse(Console.ReadLine());
            Console.WriteLine(figura);
            Console.Clear();
            switch (figura)
            {
                case 1:
                    Console.WriteLine("Ingrese el valor de x");
                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de y");
                    double y = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el radio");
                    double radio = double.Parse(Console.ReadLine());
                    FachadaCirculo fachadaCirculo = new FachadaCirculo();
                    double area=fachadaCirculo.CalcularArea(x, y, radio);
                    double perimetro=fachadaCirculo.CalcularPerimetro(x, y, radio);
                    Console.Clear();
                    Console.Write("Area:"+ area+ "\nPerímetro:"+ perimetro);
                    break;
                case 2:
                    Console.WriteLine("Ingrese el valor de x1");
                    double x1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de y1");
                    double y1 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese el valor de x2");
                    double x2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de y2");
                    double y2 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese el valor de x3");
                    double x3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de y3");
                    double y3 = double.Parse(Console.ReadLine());
                    FachadaTriangulo fachadaTriangulo = new FachadaTriangulo();
                    double areaTriangulo = fachadaTriangulo.CalcularArea(x1, y1, x2, y2, x3, y3);
                    double perimetroTriangulo = fachadaTriangulo.CalcularPerimetro(x1, y1, x2, y2, x3, y3);
                    Console.Write("Area:" + areaTriangulo + "\nPerímetro:" + perimetroTriangulo);

                    break;
                case 3:
                    Console.WriteLine("Ingrese la operacion: 1. Calcular la distancia");
                    Console.WriteLine("Ingrese el punto 1:");
                    Console.Write("X: ");
                    double X1 = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    double Y1 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese el punto 2:");
                    Console.Write("X: ");
                    double X2 = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    double Y2 = double.Parse(Console.ReadLine());
                    FachadaPunto fachadaPunto = new FachadaPunto();
                    double distancia = fachadaPunto.DistanciaEntreDosPuntos(X1, Y1, X2, Y2);
                    Console.WriteLine(distancia);
                    break;
                case 4: Console.WriteLine("ඞඞඞඞඞඞඞ"); break;
                default: Console.WriteLine(figura + " No es una opción valida"); break;
            }
        }
    }
}



