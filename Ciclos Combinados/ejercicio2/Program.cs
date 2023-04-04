using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
            //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
            int n = 0 , contImp = 0, maxPorcentaje = 0, porcentaje = 0, maxLista = 0, cont = 0, mm = 0, contL = 0;
            bool p = false;
            

            for (int x = 0; x < 5; x++)
            {
            
            Console.WriteLine("Ingrese el primer nuemro de la lista de nuemros: ");
            n = int.Parse(Console.ReadLine());


            cont = 10;
            contImp = 0;
            mm = n;
            p = false;

           

            while (n != 0)
            {
                
                cont ++;

                if (n % 2 != 0)
                {
                contImp ++;
                }

                
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                if (mm >= n)
                    mm = n;
                else 
                    p = true;
            }

            if (p == false)
                contL++;


            porcentaje = contImp * 100 / cont;

             if (x  == 0){
                maxLista = x+1;
                maxPorcentaje = porcentaje;
            }else if (porcentaje > maxPorcentaje){
                     maxPorcentaje = porcentaje;
                     maxLista = x+1;    
                    }

            }
            
            Console.WriteLine ("El numero con el mayor porcentaje de numeros impares es: " + maxLista + "%"); 
            Console.WriteLine("La cantidad de grupos ordenados de mayor a menor es: " + contL);


            
        }
    }
}
