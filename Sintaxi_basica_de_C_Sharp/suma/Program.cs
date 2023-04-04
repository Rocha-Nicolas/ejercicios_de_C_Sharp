using System;

namespace suma
{
    class Program
    {
        static void Main(string[] args)
        { 
            int n1;
            int n2;
            int r;
            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            n2 = int.Parse(Console.ReadLine());
            r = n1 + n2;
            Console.WriteLine("La suma es " + r);

        }
    }
}
