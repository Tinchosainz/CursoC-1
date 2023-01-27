using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero, 
            // “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.
            int Numero1;
            Console.WriteLine("Ingresar numero");
            Numero1 = int.Parse(Console.ReadLine());
            if(Numero1 > 0){
                Console.WriteLine("Positivo");
            }else if(Numero1 < 0){
                Console.WriteLine("Negativo");
            }else{
                Console.WriteLine("Cero");
            }
        }
    }
}
