using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
            // El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. 
            // Mostrar el resultado en pantalla
            // Ejemplo:
            // CADENA FUENTE: “La mar estaba serena"
            // CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            // CADENA RESULTADO: “Li mir estibi sereni"

            char[] frase = new char[30];
            int x = 0;
            char letravieja, letranueva;
            do{
                Console.WriteLine("ingrese letra");
                frase[x] = char.Parse(Console.ReadLine()); 
                x++;
                }while (frase[x - 1] != '.' && x < 30);
            Console.WriteLine("ingrese letra a reemplazar ");
            letravieja = char.Parse(Console.ReadLine()); 
            Console.WriteLine("ingrese nueva letra");
            letranueva = char.Parse(Console.ReadLine()); 
            x = 0;
            while (frase[x] != '.' && x < 30)
            {
                if(frase[x] == letravieja){
                    frase[x] = letranueva;
                    }
                x++;   
            }
            x = 0;
            Console.WriteLine("la nueva frase es");
            while (frase[x] != '.' && x < 30){
                Console.WriteLine(frase[x]);
                x++;
            }
        }
    }
}
