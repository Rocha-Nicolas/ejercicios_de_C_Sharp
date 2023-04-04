using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            //- Número de Artículo (1 a 15)
            //- Cantidad Vendida 

            //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            //Se pide determinar e informar:
            //a) El número de artículo que más se vendió en total.
            //b) Los números de artículos que no registraron ventas.
            //c) Cuantas unidades se vendieron del número de artículo 10.
            
            int n=0, cant = 0, max = 0, art=0;
            int [] vector = new int [15];
            

            for (int x = 0; x < 15; x++)
            {
                vector[x] = 0;
            }


            Console.WriteLine("Ingrese el Numero de Articulo: ");
            n = int.Parse(Console.ReadLine());

            while (n != 0 && n <= 15)
            {
                
                Console.WriteLine("Ingrese la cantidad vendida: ");
                cant = int.Parse(Console.ReadLine());

                vector[n-1] += cant;

                Console.WriteLine("Ingrese el Numero de Articulo: ");
                n = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Los articulos que no registraron ventas son: ");

            for (int x = 0; x < 15; x++)
            {
                if (x == 0)
                {
                    max = vector[x];
                    art = x;
                }else if (vector[x] > max)
                {
                    max = vector[x];
                    art = x;                  
                }

                if (vector[x] == 0)
                {
                    Console.Write(" "+ (x+1) + " " );
                }
            }
            Console.WriteLine("");
            if (max != 0)
            {
                Console.WriteLine("El articulo mas vendido es " + (art+1));
            }

             Console.WriteLine("La cantidad vendida del articulo numero 10 es de: " + vector[9]);

            
        }
    }
}
