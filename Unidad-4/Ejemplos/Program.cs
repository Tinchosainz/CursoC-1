using System;

namespace Ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int nac;
            Console.WriteLine("Ingrese edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nac");
            nac = int.Parse(Console.ReadLine());
            if((edad > 20 && nac == 5) || (edad > 25 && nac == 8)){
                Console.WriteLine("20 Off");
            }else{
                Console.WriteLine("10 Off");
            }
        }
    }
}
