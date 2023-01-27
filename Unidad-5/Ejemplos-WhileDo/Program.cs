using System;

namespace Ejemplos_WhileDo
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0, contador = 0;
            do{
                Console.WriteLine("Ingrese un numero");
                N = int.Parse(Console.ReadLine());
                contador++;
            }while(N != 0);
            Console.WriteLine("ingresaste " + contador + " numeros");
        }
    }
}
