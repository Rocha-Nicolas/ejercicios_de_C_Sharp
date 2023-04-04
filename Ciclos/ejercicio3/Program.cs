using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // 3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.
            int edad=0, acum=0, promedio=0, cont=0;


            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese la edad: ");
                edad = int.Parse(Console.ReadLine());
                if (edad > 18 )
                    acum += edad; 
                    cont++;
            }
            
            promedio = acum/cont;

            Console.WriteLine("El promedio de las edades mayores a 18 años es: " + promedio);
        }
    }
}
