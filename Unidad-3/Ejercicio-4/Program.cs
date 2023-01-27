using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

            int n1, n2, n3, n4, menor;
            Console.WriteLine("ingresar primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresar segundo numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresar tercer numero");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresar cuarto numero");
            n4 = int.Parse(Console.ReadLine());

            if(n1 < n2){
                menor = n1;
            }else{
                menor = n2;
            }
            if(menor > n3){
                menor = n3;
            }
            if(menor > n4){
                menor = n4;
            }
            Console.WriteLine("El menor numero es " + menor);
            }
        }
    }

