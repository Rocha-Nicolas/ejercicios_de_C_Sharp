using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3,n4;

            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            n4 = int.Parse(Console.ReadLine());

            if (n1 > 100)
                Console.WriteLine("El numero " + n1 + " es mayor a 100");
            if (n2 > 100)
                Console.WriteLine("El numero " + n2 + " es mayor a 100");
            if (n3 >100)
                Console.WriteLine("El numeor " + n3 + " es mayor a 100");
            if (n4 >100)
                Console.WriteLine("El numero " + n4 + " es mayor a 100");
        }
    }
}
