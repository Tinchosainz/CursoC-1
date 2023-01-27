using System;

namespace Ejemplos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra = 'A';
            switch(letra){
                case 'M':
                    Console.WriteLine("Mono");

                    break;
                case 'H':
                    Console.WriteLine("Homo");

                    break;
                default:
                    Console.WriteLine("Error");
                    break;                   
            }
            Console.WriteLine("Fin");
        }
    }
}
