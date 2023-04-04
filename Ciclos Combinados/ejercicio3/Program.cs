using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
           // 3. Hacer un programa para recibir listas de números positivos que están separadas 
           // entre sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
           
            int n = 0, cont = 0, numeroGrupo = 0;


            do
            {
                numeroGrupo++;
                
                cont = 0;

                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                while (n > 0 )
                {
                    cont++;
                
                    Console.WriteLine("Ingrese un numero: ");
                    n = int.Parse(Console.ReadLine());
                    
                }

                Console.WriteLine("El grupo " + numeroGrupo + " contiene " + cont + " numeros.");

            }while ( n > -1 );
        }
    }
}
