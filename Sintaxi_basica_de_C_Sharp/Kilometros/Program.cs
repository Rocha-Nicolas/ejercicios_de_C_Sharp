using System;

namespace Kilometros
{
    class Program
    {
        static void Main(string[] args)
        {   
            float k,v,r;
            Console.WriteLine("Ingrese los Kilometros entre dos ciudades");
            k = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrse la velocidad promedio de un vehiculo");
            v = float.Parse(Console.ReadLine());
            r = k / v;            
            Console.WriteLine("El tiempo estimado es " + r.ToString("0.00") + " Horas " );
        }
    }
}
