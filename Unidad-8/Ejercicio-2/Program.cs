using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
            // Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
            int N, H = 0, contador = 0;
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese numero"); 
                N = int.Parse(Console.ReadLine());
                H = par(N);
                if(H == 1){
                    contador++;
                }
            }
            Console.WriteLine(contador + " numeros son pares");

        }
        static int par(int n1){
            if(n1 % 2 == 0){
                return 1;
            }else{
                return 0;
            }
        }
    }
}
