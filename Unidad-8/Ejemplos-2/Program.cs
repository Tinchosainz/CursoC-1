using System;

namespace Ejemplos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;
            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            n2 = int.Parse(Console.ReadLine());

            resultado = sumar(n1, n2);

            Console.WriteLine("Su resultado es " + resultado);
        }
        static int sumar(int a, int b){
            int r;
            r = a + b;
            return r;
        }
    }
}
