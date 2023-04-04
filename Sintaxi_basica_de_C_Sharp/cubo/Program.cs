using System;

namespace cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,r;
            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            r = n1 * n1 * n1;
            Console.WriteLine("El numero " + n1 + " elevado al cubo es " + r );

        }
    }
}
