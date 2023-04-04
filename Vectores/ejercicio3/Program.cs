using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde 
            //todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            //CADENA FUENTE: “La mar estaba serena"
            //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            //CADENA RESULTADO: “Li mir estibi sereni"
           
           int x = 0;
           char c1, c2, letra;
           char[] cadena = new char [21];


           Console.WriteLine("Ingrese una cadena de caracteres: (finaliza con el ingreso de un '.')");
           letra = char.Parse(Console.ReadLine());
                     
           while (letra != '.' && x < 20 )
           {
            cadena[x] = letra;
            x++;
            letra = char.Parse(Console.ReadLine());
           }

           cadena[x] = '\0';
                       
            Console.WriteLine("Ingrese un  caracter: ");
            c1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un  caracter: ");
            c2 = char.Parse(Console.ReadLine());

            x = 0;
            while (cadena[x] != '\0')
            {
                if (cadena[x] == c1)
                {
                    cadena[x] = c2;
                }
            
                x++;
            }

            x = 0;

            Console.WriteLine("La frase alterada es: ");

            while (cadena[x] != '\0')
            {
                Console.Write(cadena[x]);
                x++;
            }

            string frase;
            char letraActual, letraNueva;

            Console.WriteLine("Ingrese la frase: ");
            frase = Console.ReadLine();

            Console.WriteLine("Ingrese la letra a reeemplazar");
            letraActual = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nueva letra");
            letraNueva = char.Parse(Console.ReadLine());

            frase = frase.Replace(letraActual,letraNueva);

            Console.WriteLine("La cadena nueva es ");
            Console.WriteLine(frase);




        }
    }
}
