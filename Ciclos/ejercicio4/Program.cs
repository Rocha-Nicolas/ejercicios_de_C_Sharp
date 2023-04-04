using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont = 0;
            
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());
            
            for (int x = 2; x < n; x++)
            {
                if (n % x == 0)
                    cont++; 
            }
                        
            if ( cont == 0)
                Console.WriteLine("Es un numero primo");
            else 
                Console.WriteLine("No es un numero primo");
        }
    }
}
