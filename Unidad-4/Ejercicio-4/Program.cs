using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.
            int N1, N2, N3;
            Console.WriteLine("ingrese el primer numero");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el tercer numero");
            N3 = int.Parse(Console.ReadLine());
            if((N1 + N2) > (N2 * N3)){
                Console.WriteLine("la suma del primer numero con el segundo numero es mayor a el producto del segundo numero con el tercer numero");
            }
        }
    }
}
