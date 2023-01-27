using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.
            float nota1, nota2, nota3, resultado;
            Console.WriteLine("ingrese nota del primer examen");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese nota del segundo examen");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese nota del tercer examen");
            nota3 = float.Parse(Console.ReadLine());
            resultado = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("El promedio final es de " + resultado.ToString("0.0"));
        }
    }
}
