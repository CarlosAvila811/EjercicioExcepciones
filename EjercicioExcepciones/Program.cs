using EjercicioExcepciones;
using System;

class Program
{
    static void Main()
    {
        OPeraciones operaciones = new OPeraciones();
        int opcion = 0;

        while (opcion != 5)
        {
     
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");

       
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida. Por favor, ingrese un número.");
                continue;
            }

            
            if (opcion >= 1 && opcion <= 4)
            {
                try
                {
                    Console.Write("Ingrese el primer número: ");
                    if (!double.TryParse(Console.ReadLine(), out double num1))
                    {
                        Console.WriteLine("Número inválido. Inténtelo de nuevo.");
                        continue;
                    }

                    Console.Write("Ingrese el segundo número: ");
                    if (!double.TryParse(Console.ReadLine(), out double num2))
                    {
                        Console.WriteLine("Número inválido. Inténtelo de nuevo.");
                        continue;
                    }

                    double resultado = 0;

                    switch (opcion)
                    {
                        case 1:
                            resultado = operaciones.Sumar(num1, num2);
                            break;
                        case 2:
                            resultado = operaciones.Restar(num1, num2);
                            break;
                        case 3:
                            resultado = operaciones.Multiplicar(num1, num2);
                            break;
                        case 4:
                            resultado = operaciones.Dividir(num1, num2);
                            break;
                    }

                    Console.WriteLine($"El resultado es: {resultado}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else if (opcion != 5)
            {
                Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 5.");
            }
        }

        Console.WriteLine("Programa terminado.");
    }
}