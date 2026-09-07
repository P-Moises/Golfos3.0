using System;

namespace EST30_Ejercicios
{
    class Ej08_EST30
    {
        public static void Ejecutar()
        {
            const int TOTAL = 5;

            int numero = 1;
            int pares = 0;
            int impares = 0;

            while (numero <= TOTAL)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine("Registro " + numero + ": TURNO DE LA MAÑANA");
                    pares++;
                }
                else
                {
                    Console.WriteLine("Registro " + numero + ": TURNO DE LA TARDE");
                    impares++;
                }

                numero++;
            }

            Console.WriteLine("\nPares - mañana: " + pares);
            Console.WriteLine("Impares - tarde: " + impares);
            Console.WriteLine("Total: " + (pares + impares));
        }
    }
}