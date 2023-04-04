using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // 1. Hacer un programa que solicite 10 números enteros 
            // y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
            int n, max = 0 , p = 0;
            int [] vector = new int [10];

           for (int x = 0; x < 10; x++)
           {
            
            Console.WriteLine("ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            vector [x] = n;

        //    if ( x == 0)
        //    {
        //        max = n;
        //        p = x; 
        //    }else if ( n > max )
        //        {                
        //            max = n;
        //            p = x;
        //        }
           }

            for (int x = 0; x < 10; x++)
            {
                if ( vector [x] == 0)
            {
                max = vector[x];
                p = x; 
            }else if ( vector[x] > max )
                {                
                    max = vector[x];
                    p = x;
                }
            }


           Console.WriteLine("El numero mayor del vector es: " + max + " en la posicion " + p + " del vector ");
            
        }
    }
}
