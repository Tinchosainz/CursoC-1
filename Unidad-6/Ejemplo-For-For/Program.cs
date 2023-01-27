using System;

namespace Ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int promedio, Total, N;
            for (int X = 0; X < 2; X++)
            {
                Total = 0;
                for (int Y = 0; Y < 5; Y++)
                {
                    Console.WriteLine("Ingrese edad");
                    N = int.Parse(Console.ReadLine());
                    Total += N;
                }
                promedio = Total / 5;
                Console.WriteLine("La edad promedio es " + promedio);
            }
        }
    }
}
