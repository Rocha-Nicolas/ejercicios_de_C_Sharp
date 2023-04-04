using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números.
            // El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.
            
            int cont= 0, cant = 0, n;
            
            Console.WriteLine("Ingrese un numero ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                if (primo(n) == 1)
                {
                    cant += +n;
                    cont++;
                }
                Console.WriteLine("Ingrese un numero ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El promedio es " + (cant/cont)+ " la cantidad de numeros primos son "+ cont);


        }

        static int primo(int n)
        {
            int cont=0;

            for (int x = 2; x < n; x++)
                {
                if (n % x == 0)
                    cont++; 
                }
                        
                if ( cont == 0)
                    return 1;
                else return 0;
        }
    }
}
