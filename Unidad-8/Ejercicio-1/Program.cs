using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
            // Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. 
            // Usar la función.
            
            int precio, cantidad, precioTotal;

            Console.WriteLine("ingrese precio del articulo");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese cantidad de articulos vendidos");
            cantidad = int.Parse(Console.ReadLine());
            precioTotal = producto(precio, cantidad);
            Console.WriteLine("El monto total a pagar es de " + precioTotal);
        }
        static int producto(int n1, int n2){
            int resultado;
            resultado = n1 * n2;
            return resultado;
        }
    }
}
