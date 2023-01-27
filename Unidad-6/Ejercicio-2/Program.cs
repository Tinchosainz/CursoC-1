using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
            //     El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            //     Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
            int N, CantNum, CantImp, PorcentajeImpares, MayorPorcentaje = 0, GrupMI = 0, comprobador, GrupO = 0, Na;
            for (int X = 0; X < 5; X++){
                CantNum = 0;
                CantImp = 0;
                PorcentajeImpares = 0;
                comprobador = 1;
                Na = 0;
                Console.WriteLine("ingrese numero");
                N = int.Parse(Console.ReadLine());
                while (N != 0){
                    CantNum++;
                    if(N % 2 != 0){
                        CantImp++;
                    }
                    if(CantNum == 1){
                        Na = N;
                    }
                    if(N < Na){
                        comprobador++;
                        Na = N;
                    }
                    
                    Console.WriteLine("ingrese numero");
                    N = int.Parse(Console.ReadLine());
                }
                PorcentajeImpares = CantImp * 100 / CantNum;
                if(PorcentajeImpares > MayorPorcentaje){
                    MayorPorcentaje = PorcentajeImpares;
                    GrupMI = X + 1;
                }
                if(comprobador == CantNum){
                    GrupO++;
                }
            }
            if(GrupMI == 0){
                Console.WriteLine("ningun grupo tiene impares");
            }else{
                Console.WriteLine("El grupo con mayor porcentaje de impares es el grupo " + GrupMI);
            }
            Console.WriteLine( GrupO + " grupos estan ordenados de mayor a menor ");
        }
    }
}
