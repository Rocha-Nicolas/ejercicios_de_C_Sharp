using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // 2. Hacer un programa que solicite 10  números enteros 
            // y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.
            
            int n, promedio, acu = 0;
            int [] numeros = new int [10];

            for (int x = 0; x < 10; x++)
            {
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            numeros[x] = n;
            }

            for (int x = 0; x < 10; x++)
            {
                acu += numeros[x];
            }

            promedio = acu / 10;

            Console.WriteLine("El promedio es: " + promedio);

            for (int x = 0; x < 10; x++)
            {
                if (numeros[x] > promedio)
                {
                    Console.WriteLine("El numero " + numeros[x] + " es mayor al promeido");
                }
            }


        }

         
    }
}
