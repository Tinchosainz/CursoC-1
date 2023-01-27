using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
            
            int N, contador, Total = 0;
            for (int x = 0; x < 10; x++){
            Console.WriteLine("ingrese numero");
            N = int.Parse(Console.ReadLine());
            contador = 0;
                for (int y = 1; y <= N; y++){
                
                    if(N % y == 0){
                            contador++;
                        }
                }
            if(contador == 2){
                Total ++;
            }
            }
            Console.WriteLine( Total + " Son primos");
        }
    }
}
