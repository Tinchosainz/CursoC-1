using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
            // Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

            int[] numeros = new int[10];
            int mayor, posicion = 1;
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese numero");
                numeros[x] = int.Parse(Console.ReadLine()); 
            }
            mayor = numeros[0];
            for (int x = 0; x < 10; x++)
            {
                if(mayor <= numeros[x]){
                    mayor = numeros[x];
                    posicion = x + 1;
                }
            }
            Console.WriteLine(" el numero mayor es " + mayor + " y se encuentra en la posicion " + posicion);
        }
    }
}
