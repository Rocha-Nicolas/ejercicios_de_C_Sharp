using System;

namespace sueldo
{
    class Program
    {
        static void Main(string[] args)
        {   
            float f;
            double s;
            Console.WriteLine("Ingrese el total facturado");
            f = float.Parse(Console.ReadLine());
            s = 15000 + ( f * 0.05);
            Console.WriteLine("El sueldo es "+ s);
        }
    }
}
