using System;

namespace TPFinal_Rocha
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

                // a. El mayor de los números pares.
                // b. La cantidad de números impares.
                // c. El menor de los números primos.

            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.
            
            int numero, contImpares = 0, menorPrimos = 0, numeroMayor = 0;
            bool banderaPares = true, banderaPrimos = true;

                        
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                if (numero % 2 == 0)
                {
                    if (banderaPares == true)
                    {
                        numeroMayor = numero;
                        banderaPares = false;
                    }    
                    else if (numero > numeroMayor)
                            numeroMayor = numero;
                }else contImpares++;

                if ( numerosPrimos(numero))
                {
                    if (banderaPrimos == true)
                    {
                        menorPrimos = numero;
                        banderaPrimos = false;
                    }
                    else if (numero < menorPrimos)
                            menorPrimos = numero;
                }
                
                Console.WriteLine("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El numero " + numeroMayor + " es el mayor de los numeros pares");
            Console.WriteLine("La cantidad de numeros impares es de " + contImpares);
            Console.WriteLine("El menor de los numeros primos es de " + menorPrimos);
        }

        static bool numerosPrimos (int numero)
        {
            
            int cont=0;

            for (int x = 2; x < numero; x++)
                {
                if (numero % x == 0)
                    cont++; 
                }
                        
                if ( cont == 0)
                    return true;
                else return false;
        }
    }
}
