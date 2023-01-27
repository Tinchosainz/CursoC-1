using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
            int n1, n2, n3, n4;
            Console.WriteLine("ingresar primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresar segundo numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresar tercer numero");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresar cuarto numero");
            n4 = int.Parse(Console.ReadLine());

            if(n1 > 100){
                if(n2 > 100){
                    if(n3 > 100){
                        if(n4 > 100){
                            Console.WriteLine("los numeros mayores a 100 son "  + n1 + " " + n2 + " " + n3 + " "  + n4);
                        }else{
                            Console.WriteLine("los numeros mayores a 100 son "  + n1 + " " + n2 + " " + n3);
                        }
                    }else if(n4 > 100){
                        Console.WriteLine("los numeros mayores a 100 son "  + n1 + " " + n2 + " "  + n4);
                    }else{
                        Console.WriteLine("los numeros mayores a 100 son "  + n1 + " " + n2);
                    }
                }else if(n3 > 100){
                    if(n4 > 100){
                        Console.WriteLine("los numeros mayores a 100 son " + n1 + " " + n3 + " " + n4);
                    }else{
                        Console.WriteLine("los numeros mayores a 100 son " + n1 + " " + n3);
                    }
                }else if(n4 > 100){
                    Console.WriteLine("los numeros mayores a 100 son " + n1 + " " + n4);
                }else{
                    Console.WriteLine("el numero mayor a 100 es " + n1);
                }
            }else if(n2 > 100){
                if(n3 > 100){
                    if(n4 > 100){
                        Console.WriteLine("los numeros mayores a 100 son " + n2 + " " + n3 + " " + n4);
                    }else{
                        Console.WriteLine("los numeros mayores a 100 son " + n1 + " " + n3);
                    }
                }else if(n4 > 100){
                    Console.WriteLine("los numeros mayores a 100 son " + n1 + " " + n4);
                }else{
                    Console.WriteLine("el numero mayor a 100 es " + n2);
                }
            }else if(n3 > 100){
                if(n4 > 100){
                    Console.WriteLine("los numeros mayores a 100 son " + n3 + " " + n4);
                }else{
                    Console.WriteLine("el numero mayor a 100 es " + n3);
                }
            }else if(n4 > 100){
                Console.WriteLine("el numero mayor a 100 es " + n4);
            }else{
                Console.WriteLine("ningun numero es mayor a 100");
            }




        }
    }
}
