using System;

namespace Ejemplos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] muestratemp = new double[5];
            int dia;
            double temperatura;
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese dia");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese temperatura");
                temperatura = double.Parse(Console.ReadLine());
                muestratemp[dia - 1] = temperatura;
            }
            for (int x = 0; x < 5; x++)
            {
                dia = x + 1;
                Console.WriteLine("El dia " + dia + " se registro " + muestratemp[x] + " grados");
            }
        }
    }
}
