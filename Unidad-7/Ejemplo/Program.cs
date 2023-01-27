using System;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            for (int x = 0; x < 10; x++){
                Console.WriteLine("ingrese numero");
                numeros[x] = int.Parse(Console.ReadLine());
            }
            int Acumulador = 0;
            for (int x = 0; x < 10; x++){
                Acumulador += numeros[x];
            }
            int Promedio = Acumulador / 10;
            Console.WriteLine("Promedio " + Promedio);
        }
    }
}
