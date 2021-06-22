using System;

namespace Tarea05_01
{
    class Program
    {
        static void pintaMenu()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Seleccione una opción: ");
            Console.WriteLine("1 - Calcular área de un círculo.");
            Console.WriteLine("2 - Calcular área de un triángulo.");
            Console.WriteLine("3 - Calcular área de un cuadrado.");
            Console.WriteLine("0 - SALIR.");
            Console.WriteLine("----------------------------------------");
        }

        static double circulo(double radio)
        {
            double resultado = Math.Pow( radio,2) * Math.PI;
            return resultado;
        }

        static double triangulo (double baset, double altura)
        {
            double resultado = (baset*altura)/2;
            return resultado;
        }
        static double cuadrado ( double lado)
        {
            double resultado = lado * lado;
            return resultado;
        }
        static void Main(string[] args)
        {
            string opcion = "";
            double datoRadio = 0;
            double datoLado = 0;
            double datoBase = 0;
            double datoAltura = 0;


            while (opcion != "0")
            {
                pintaMenu();
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Introduce el radio del círculo: ");
                        datoRadio = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("El área del círculo es: {0}: ", circulo(datoRadio));
                        break;
                    case "2":
                        Console.WriteLine("Introduce la base del triángulo: ");
                        datoBase = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Introduce la altura del triángulo: ");
                        datoAltura = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("El área del triángulo es: {0}: ", triangulo(datoBase, datoAltura));
                        break;
                    case "3":
                        Console.WriteLine("Introduce el lado del cuadrado: ");
                        datoLado = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("El área del cuadrado es: {0}: ", cuadrado(datoLado));
                        break;
                    case "0":
                        Console.WriteLine("Fin del programa");
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;

                }

            }
            
            
            Console.ReadKey();
        }
    }
}
