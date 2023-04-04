using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3,n4,menor;

            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            n4 = int.Parse(Console.ReadLine());

            if (n1<n2)
                menor = n1;
            else
                menor = n2;
            if (menor > n3)
                menor = n3;
            if (menor > n4)
                menor = n4;

            Console.WriteLine("El numero menor de los cuatro numeros es: " + menor);
        }
    }
}
