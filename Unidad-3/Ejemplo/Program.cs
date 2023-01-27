using System;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Ingrese edad");
            edad = int.Parse(Console.ReadLine());
            if(edad > 30){
                Console.WriteLine("Viejo");
            }else if(edad > 20){
                Console.WriteLine("Normal");
            }else if(edad > 16){
                Console.WriteLine("Joven");
            }else{
                Console.WriteLine("Nene");
            }                  
        }
    }
}
