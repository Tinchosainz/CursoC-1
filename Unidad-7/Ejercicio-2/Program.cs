 using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. 
            // Mostrar por pantalla los valores que son mayores al promedio.
            
            int[] numeros = new int[10];
            int acu = 0, promedio = 0;
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese numero");
                numeros[x] = int.Parse(Console.ReadLine()); 
            }
            for (int x = 0; x < 10; x++)
            {
                acu += numeros[x];
            }
            promedio = acu / 10;
            Console.WriteLine("el promedio es " + promedio);
            for (int x = 0; x < 10; x++)
            {
                if(numeros[x] > promedio){
                    Console.WriteLine("el valor " + numeros[x] + " es mayor al promedio" );
                }
            }
        }
    }
}
