using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.
            int N, M = 0;
            for(int x = 0; x < 10; x++){
                Console.WriteLine("ingrese numero");
                N = int.Parse(Console.ReadLine());
                if( x == 0){
                    M = N;
                }
                if(M < N){
                    M = N;
                }
            }
            Console.WriteLine("El mayor numero es " + M );
        }
    }
}
