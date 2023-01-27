using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.
            int N1, resultado;
            Console.WriteLine("Ingresar numero");
            N1 = int.Parse(Console.ReadLine());
            resultado = N1 * N1 * N1;
            Console.WriteLine("El resultado es " + resultado);
        }
    }
}
