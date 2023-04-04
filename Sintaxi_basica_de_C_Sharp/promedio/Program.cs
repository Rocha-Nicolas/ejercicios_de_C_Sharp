using System;

namespace promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1,n2,n3, p;
            Console.WriteLine("Ingrese la primer nota");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercer nota");
            n3 = float.Parse(Console.ReadLine());
            p = (n1 + n2 + n3) / 3;
            Console.WriteLine("El promedio es " + p.ToString("0.00"));
        }
    }
}
