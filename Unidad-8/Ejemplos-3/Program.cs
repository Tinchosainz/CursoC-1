using System;

namespace Ejemplos_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, resultado;

            pedirDatos(ref n1, ref n2);

            resultado = sumar(n1, n2);

            Console.WriteLine("Su resultado es " + resultado);
        }

        static int sumar(int a, int b){
            int r;
            r = a + b;
            return r;
        }

        static void pedirDatos(ref int J, ref int H){
            Console.WriteLine("Ingrese un numero");
            J = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            H = int.Parse(Console.ReadLine());
        }
    }
}
