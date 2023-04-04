using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia.
            // Que analice el número y escriba variable recibida por referencia con:

            // a. 1 si el número es positivo.
            // b. -1 si el número es negativo.
            // c. 0 si el número es cero.
            int n , r=2;

            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            positivonegativocero(n ,ref r);

            Console.WriteLine("El numero ingresado es "+ r );
        }

        static void positivonegativocero(int n, ref int r)
        {
            if( n > 0 )
                r = 1;
            if( n < 0 )
                r = -1;
            if( n == 0 )
                r = 0;
        }
    }
}
