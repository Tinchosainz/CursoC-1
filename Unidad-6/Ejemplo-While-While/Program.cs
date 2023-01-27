using System;

namespace Ejemplo_While_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int promedio, Total, N, Cantidad;
            Console.WriteLine("Ingrese edad");
            N = int.Parse(Console.ReadLine());
            
            while (N >= 0 && N != 0){
                Cantidad = 0;
                Total = 0; 
                while (N != 0){
                    Cantidad++;
                    Total += N;
                    Console.WriteLine("Ingrese edad");
                    N = int.Parse(Console.ReadLine());
                }
                promedio = Total / Cantidad;
                Console.WriteLine("La edad promedio es " + promedio);
                
                Console.WriteLine("Ingrese 1 para continuar o -1 para terminar");
                N = int.Parse(Console.ReadLine());
            }
        }
    }
}
