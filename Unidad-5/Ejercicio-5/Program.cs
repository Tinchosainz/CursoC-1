using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.
            int n, mp = 0, mi = 0, contadorP = 0, contadorI = 0;
            for(int x = 0;x < 20; x++){
                Console.WriteLine("ingrese numero");
                n = int.Parse(Console.ReadLine());
                if(n % 2 == 0){
                    contadorP++;
                    if(contadorP == 1){
                        mp = n;
                    }else if(n > mp){
                        mp = n;
                    }
                }else{
                    contadorI++;
                    if(contadorI == 1){
                        mi = n;
                    }else if(n < mi){
                        mi = n;
                    }
                }
            } 
            Console.WriteLine("el maximo par es " + mp + " y el minimo impar es " + mi);
        }
    }
}
