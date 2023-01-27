using System;

namespace Ejemplos_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] Asistencia = new bool[15];
            int Acumuladordefaltas = 0, Acumuladordeasistencias = 0, clase = 0;
            for (int x = 0; x < 15; x++)
            {
                Console.WriteLine("Presente = 1 / Ausente = 0");
                clase = int.Parse(Console.ReadLine());
                if(clase == 0){
                    Asistencia[x] = false;
                }else{
                    Asistencia[x] = true;
                }
                if(Asistencia[x] == false){ 
                    Acumuladordefaltas++;
                }else{
                    Acumuladordeasistencias++;
                }
            }
            Console.WriteLine("Falto " + Acumuladordefaltas + " veces");    
        }
    }
}
