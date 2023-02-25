using System;

namespace semana5
{
    class Program
    {
        static void Main(string[] args)
        {
            int rango_ini;
            int rango_fin;
            int parCount = 0; 

            Console.Write("Ingrese un numero de rango inicial: ");
            rango_ini = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero de rango final: ");
            rango_fin = int.Parse(Console.ReadLine());

            Console.WriteLine("Los números pares entre " + rango_ini + " y " + rango_fin + " son:");

            for (int i = rango_ini; i <= rango_fin; i++)
            { 
                if (i % 2 == 0)
                { Console.WriteLine(i.ToString());
                    parCount++;
                }

                else
                {
                   
                }
            }

        }
    }
}





