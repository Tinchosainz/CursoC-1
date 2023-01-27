using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. 
            // Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
            float sueldofijo, facturacion, resultado, comision;
            sueldofijo = 15000;
            comision = 0.05f;
            Console.WriteLine("Ingrese el total facturado por el empleado");
            facturacion =float.Parse(Console.ReadLine());
            resultado = facturacion * comision + sueldofijo;
            Console.WriteLine("El sueldo total del empleado es de " + resultado);

        }
    }
}
