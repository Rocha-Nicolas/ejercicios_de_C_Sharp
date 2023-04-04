using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

            //La resta si el primero es mayor que el segundo.
            //La suma si son iguales.
            //El producto si el primero es menor.
            //Se deberá emitir un cartel por pantalla con el resultado correspondiente.
           
            int a,b,r;

            Console.WriteLine("Ingrese un numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: ");
            b = int.Parse(Console.ReadLine());

            if ( a > b ){
                r = a - b ;
                Console.WriteLine("El primer numero es mayor que el segundo "+ r);
            }
            if ( a == b ){
                r = a + b ;
                Console.WriteLine("El primer numero es igual que el segundo "+ r);
            }
            else{ 
                r = a * b ;
                Console.WriteLine("El primer numero es menor que el segundo "+ r);
            }
            
        }
    }
}
