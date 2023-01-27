using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
            // Hacer un programa para ingresar números. 
            // El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.
            int N, contador2 = 0, acumulador = 0, promedio;
            do{
                Console.WriteLine("ingrese un numero");
                N = int.Parse(Console.ReadLine());
                if(primo(N) == 1){
                    contador2++;
                    acumulador += N;
                }
            }while(N != 0);
            promedio = acumulador / contador2;
            Console.WriteLine("el promedio de los primos es de " + promedio);

        }
        static int primo(int n1){
                int contador = 0;
                for (int x = 1; x <= n1; x++)
                {
                    if(n1 % x == 0){
                        contador++;
                    }
                }
                if(contador == 2){
                    return 1;
                }else{
                    return 0;
                }
        }
    }
}
