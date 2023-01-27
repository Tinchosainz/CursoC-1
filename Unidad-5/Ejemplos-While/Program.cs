using System;

namespace Ejemplos_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, contador = 0;
            Console.WriteLine("ingrese un numero");
            N = int.Parse(Console.ReadLine());
            while(N != 0){
                contador++;
                Console.WriteLine("ingrese un numero");
                N = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingresaste " + contador + " numeros");
        }
    }
}
