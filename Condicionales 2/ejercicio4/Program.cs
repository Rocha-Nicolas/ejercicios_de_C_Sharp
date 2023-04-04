using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            Console.WriteLine("Ingrese un numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: ");
            c = int.Parse(Console.ReadLine());

            if ((a+b) > (b*c))
                Console.WriteLine("La suma de los dos primeros es mayor al producto del segundo con el tercero");

            Console.WriteLine("Fin del Programa");
        }
    }
}
