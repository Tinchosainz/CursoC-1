using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite el ingreso de dos números y luego calcular:

            //La resta si el primero es mayor que el segundo.
            //La suma si son iguales.
            //El producto si el primero es menor.
            //Se deberá emitir un cartel por pantalla con el resultado correspondiente.
            int N1, N2, resultado;
            Console.WriteLine("Ingrese el primer numero");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            N2 = int.Parse(Console.ReadLine());

            if(N1 > N2){
                resultado = N1 - N2;
            }else if(N1 < N2){
                resultado = N1 * N2;
            }else{
                resultado = N1 + N2;
            }
            Console.WriteLine("El resultado es " + resultado);
        }
    }
}
