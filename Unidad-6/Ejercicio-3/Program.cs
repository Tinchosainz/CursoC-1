using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se notifica con un número negativo. 
            // Luego mostrar cuántos números tiene cada lista.
            
            int N = 1, ContLista = 0, ContNum;
            while (N > 0){
                Console.WriteLine("ingrese numero");
                N = int.Parse(Console.ReadLine());
                ContLista++;
                ContNum = 0;
                while (N != 0){
                    ContNum++;
                    Console.WriteLine("ingrese numero");
                    N = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("la lista " + ContLista + " tiene " + ContNum + " numeros");
                Console.WriteLine("ingrese numero positivo para seguir o negativo para finalizar");
                N = int.Parse(Console.ReadLine());
            }
        }
    }
}
