using System;

namespace Tp1_Sainz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

            // a. El mayor de los números pares.
            // b. La cantidad de números impares.
            // c. El menor de los números primos.  

            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

            int contadordeimpares = 0, contadordepares = 0, N, mayorPar = 0, contadordeprimos = 0, menorprimo = 0;
            bool H = false;
            do{
                Console.WriteLine("Ingrese un numero");
                N = int.Parse(Console.ReadLine());
                if(N % 2 == 0){
                    contadordepares++;
                    if(contadordepares == 1){
                        mayorPar = N;
                    }else if(N > mayorPar){
                        mayorPar = N;
                    }
                }else{
                    contadordeimpares++;
                }
                primos(N, ref H);
                if(H == true){
                    contadordeprimos++;
                    if(contadordeprimos == 1){
                        menorprimo = N;
                    }else if(N < menorprimo){
                        menorprimo = N;
                    }
                }

            }while(N != 0);

            
            Console.WriteLine("el mayor de los numeros pares ingresados es " + mayorPar);   
            Console.WriteLine("La cantidad de impares ingresados fue de " + contadordeimpares);
            Console.WriteLine("El menor de los primos es " + menorprimo);
            
        }

        static void primos(int n1, ref bool n2){
            int contador = 0;
                for (int x = 1; x <= n1; x++)
                {
                    if(n1 % x == 0){
                        contador++;
                    }
                }
                if(contador == 2){
                    n2 = true;
                }else{
                    n2 = false;
                }
        }
    }
}
