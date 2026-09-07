using System;

namespace EST30_Ejercicios
{
    class Ej05_EST30
    {
        public static void Ejecutar()
        {
            const int TOTAL_CONJUNTOS = 5;
            const int UMBRAL = 400;

            int cumplen = 0;
            int noCumplen = 0;

            for (int i = 1; i <= TOTAL_CONJUNTOS; i++)
            {
                Console.Write("Descargas del conjunto " + i + ": ");
                int descargas = int.Parse(Console.ReadLine());

                if (descargas >= UMBRAL)
                {
                    Console.WriteLine("CUMPLE");
                    cumplen++;
                }
                else
                {
                    Console.WriteLine("NO CUMPLE");
                    noCumplen++;
                }
            }

            Console.WriteLine("\nCumplen: " + cumplen);
            Console.WriteLine("No cumplen: " + noCumplen);
            Console.WriteLine("Total: " + (cumplen + noCumplen));
        }
    }
}