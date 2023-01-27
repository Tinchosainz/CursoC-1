using System;

namespace Ejemplo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int promedio, Total, N, Cantidad;
            for (int X = 0; X < 2; X++)
            {
                Cantidad = 0;
                Total = 0;
                Console.WriteLine("Ingrese edad");
                N = int.Parse(Console.ReadLine());
                
                while (N != 0){
                    Cantidad++;
                    Total += N;
                    Console.WriteLine("Ingrese edad");
                    N = int.Parse(Console.ReadLine());
                }
                promedio = Total / Cantidad;
                Console.WriteLine("La edad promedio es " + promedio);
            }
        }
    }
}
