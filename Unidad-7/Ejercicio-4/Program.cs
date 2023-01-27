using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            // - Número de Artículo (1 a 15)
            // - Cantidad Vendida 

            // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            // Se pide determinar e informar:
            // a) El número de artículo que más se vendió en total.
            // b) Los números de artículos que no registraron ventas.
            // c) Cuantas unidades se vendieron del número de artículo 10.

            int[] articulo = new int[15];
            int Numeroarticulo, Cantidadvendida, mayor = 0, articulomv = 0, articulosv = 0;
            

            do
            {
                Console.WriteLine("ingrese numero de articulo");
                Numeroarticulo = int.Parse(Console.ReadLine());
                if(Numeroarticulo != 0){
                    Console.WriteLine("ingrese cantidad vendida");
                    Cantidadvendida = int.Parse(Console.ReadLine());
                    articulo[Numeroarticulo - 1] += Cantidadvendida;}
                }while(Numeroarticulo != 0);
            articulo[0] = mayor;
            for (int x = 0; x < 15; x++)
            {
                if(articulo[x] > mayor){
                    mayor = articulo[x];
                    articulomv = x + 1;
                    }
            }
            Console.WriteLine("el articulo mas vendido fue el " + articulomv + " con " + mayor + " ventas");
            for (int x = 0; x < 15; x++)
            {
                 articulosv = x + 1;
                 if(articulo[x] == 0){
                 Console.WriteLine("el articulo " + articulosv + " no vendio nada");
                 }
            }
            Console.WriteLine("se vendieron " + articulo [9] + " unidades del articulo 10");
        }
    }
}
