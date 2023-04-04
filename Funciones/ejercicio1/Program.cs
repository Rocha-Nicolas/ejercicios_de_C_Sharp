using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
           
           // 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos.
           // Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.

            float precio, cant, monto;
           
            Console.WriteLine("Ingrese el precio del articulo: ");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cant = float.Parse(Console.ReadLine());

            monto = producto(precio,cant);
            
            Console.WriteLine("El monto a pagar es " + monto);
        }

        static float producto (float precio,float cant)
        {   
            float monto;

            monto = precio * cant;
            return monto;

        }
    }
}
