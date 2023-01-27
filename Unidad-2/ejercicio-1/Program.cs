using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.
            int N1, N2;
            int resultado;
            Console.WriteLine("ingresar numero");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese numero");
            N2 = int.Parse(Console.ReadLine());
            resultado = N1 + N2;
            Console.WriteLine("el resultado es "+ resultado);


        }
    }
}
