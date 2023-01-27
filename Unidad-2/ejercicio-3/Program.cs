using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. 
            // Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.
            float KM, VEL, resultado;
            Console.WriteLine("Ingrese distancia entre las dos ciudades");
            KM = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese velocidad promedio en Km/H");
            VEL = float.Parse(Console.ReadLine());
            resultado = KM / VEL;
            Console.WriteLine("El tiempo aproximado de viaje es de  " + resultado.ToString("0.00") + " horas");

        }
    }
}
