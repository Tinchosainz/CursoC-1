using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente.
            int N1, N2, N3, N4;
            Console.WriteLine("ingrese el primer numero");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el tercer numero");
            N3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el cuarto numero");
            N4 = int.Parse(Console.ReadLine());

            if(N1 > N2 && N2 > N3 && N3 > N4){
                Console.WriteLine(" estan ordenados de forma decreciente");
            }else{
                Console.WriteLine("No estan ordenados de forma decreciente");
            }
        }
    }
}
