﻿using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.
            int Numero1;
            Console.WriteLine("Ingresar numero");
            Numero1 = int.Parse(Console.ReadLine());
            if(Numero1 > 10){
                Console.WriteLine("Es mayor a 10");
            }else{
                Console.WriteLine("No es mayor a 10");
            }

        }
    }
}
