using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.
            int E, Cantidad = 0, Promedio = 0, Final;
            for(int x = 0; x < 20; x++){
                Console.WriteLine("Ingrese edad");
                E = int.Parse(Console.ReadLine());
                if(E > 18){
                    Promedio = Promedio + E;
                    Cantidad++;
                }
            }
            Final = Promedio / Cantidad;
            Console.WriteLine("El promedio de edades mayores a 18 es " + Final);
        }
    }
}
