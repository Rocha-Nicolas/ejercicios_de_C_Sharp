using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // 5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.
            
            int n = 0, max = 0, min = 0;
            bool p = false, q = false; 

            for (int x = 0; x < 20; x++)
            {
                
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());

                if( n % 2 == 0)
                {
                    if (p == false )
                    {
                        max = n;
                        p =  true;
                    }
                    else if (n > max)
                            max = n;
                }
                else if (q == false )
                    {
                        min = n;
                        q = true; 
                    }
                    else if (n < min)
                            min = n;

            }

            Console.WriteLine("El mayor de los numeros PARES es: " + max + " El menor de los numeros IMPARES es: "+ min);


            
        }
    }
}
