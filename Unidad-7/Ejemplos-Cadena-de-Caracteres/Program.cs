using System;

namespace Ejemplos_Cadena_de_Caracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] cadena = new char[10];
            int x = 0, lugar = 0;
            do{
                Console.WriteLine("Ingrese su nombre");
                cadena[x] = char.Parse(Console.ReadLine());
                x++;
            }while(cadena[x - 1] != '.' && x < 10);
            
            for (int y = 0; y < 10; y++)
            {
                if(cadena[y] == '.'){
                    y = 10;
                }else{
                    lugar = y + 1;
                    Console.WriteLine("la letra " + cadena[y] + " es la numero " + lugar + " en su nombre");
                } 
            }
        }
    }
}
