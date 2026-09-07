using System;

namespace EST30_Ejercicios
{
    class Ej16_EST30
    {
        public static void Ejecutar()
        {
            const int CENTROS = 9;
            const int ALTO = 500;
            const int MEDIO = 250;

            double totalIncentivo = 0;
            int observaciones = 0;

            for (int i = 1; i <= CENTROS; i++)
            {
                Console.Write("Dosis del centro " + i + ": ");
                int dosis = int.Parse(Console.ReadLine());

                double incentivo;

                if (dosis >= ALTO)
                    incentivo = dosis * 0.20;
                else if (dosis >= MEDIO)
                    incentivo = dosis * 0.10;
                else
                {
                    incentivo = 0;
                    observaciones++;
                }

                totalIncentivo += incentivo;

                Console.WriteLine("Incentivo: " + incentivo);
            }

            Console.WriteLine("\nIncentivo total: " + totalIncentivo);
            Console.WriteLine("Observaciones: " + observaciones);
        }
    }
}