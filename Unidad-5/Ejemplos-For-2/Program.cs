using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float N = 0, conteo = 0, promedio;
            for (float i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero");
            N = float.Parse(Console.ReadLine());
            conteo += N;
            }
            promedio = conteo / 5;
            Console.WriteLine("el promedio es " + promedio);
        }
    }
}
