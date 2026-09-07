using System;

namespace EST30_Ejercicios
{
    class Ej18_EST30
    {
        public static void Ejecutar()
        {
            const int ANIO_INICIAL = 2017;
            const int TOTAL_ANIOS = 14;

            int totalTramos = 0;
            int hitosConmemorados = 0;

            for (int i = 1; i <= TOTAL_ANIOS; i++)
            {
                int anio = ANIO_INICIAL + i - 1;

                Console.Write("Tramos registrados en " + anio + ": ");
                int tramos = int.Parse(Console.ReadLine());

                totalTramos += tramos;

                if (i % 5 == 0)
                {
                    Console.Write("¿Hubo acto conmemorativo? (1=Si, 2=No): ");
                    int acto = int.Parse(Console.ReadLine());

                    if (acto == 1)
                    {
                        Console.WriteLine("Hito conmemorado.");
                        hitosConmemorados++;
                    }
                    else
                    {
                        Console.WriteLine("Hito sin conmemoracion.");
                    }
                }
            }

            Console.WriteLine("\nTotal de tramos: " + totalTramos);
            Console.WriteLine("Hitos conmemorados: " + hitosConmemorados);
        }
    }
}