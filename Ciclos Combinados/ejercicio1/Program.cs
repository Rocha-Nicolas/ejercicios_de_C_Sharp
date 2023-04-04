using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // 1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

            int n = 0, cont = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
                cont = 0;
                for (int y = 2; y < n; y++)
                {
                if (n % y == 0)
                    cont++; 
                }
                        
                if ( cont == 0)
                Console.WriteLine("Es un numero primo");
                else 
                Console.WriteLine("No es un numero primo");
            }
            
        }
    }
}
