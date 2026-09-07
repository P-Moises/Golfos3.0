using System;

namespace EST30_Ejercicios
{
    class Ej19_EST30
    {
        public static void Ejecutar()
        {
            const int META = 9000;
            const int PUNTOS_INTENSIVA = 400;
            const int PUNTOS_PREVENTIVA = 200;
            const int UMBRAL_ALTO = 6000;
            const int UMBRAL_MEDIO = 3000;

            int recursos = 3;
            int puntos = 0;
            bool retirarse = false;

            do
            {
                Console.WriteLine("\nRecursos: " + recursos);
                Console.WriteLine("Puntos: " + puntos);
                Console.WriteLine("1. Intervencion intensiva");
                Console.WriteLine("2. Intervencion preventiva");
                Console.WriteLine("3. Retirarse");
                Console.Write("Estrategia: ");

                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    puntos += PUNTOS_INTENSIVA;
                    recursos--;

                    if (recursos == 1)
                        Console.WriteLine("ALERTA: queda un solo recurso.");
                }
                else if (opcion == 2)
                {
                    puntos += PUNTOS_PREVENTIVA;
                }
                else if (opcion == 3)
                {
                    retirarse = true;
                }
                else
                {
                    Console.WriteLine("Opcion no valida.");
                }

            } while (recursos > 0 && !retirarse && puntos < META);

            Console.WriteLine("\nPuntaje final: " + puntos);

            if (puntos >= UMBRAL_ALTO)
                Console.WriteLine("DEMANDA ALTA");
            else if (puntos >= UMBRAL_MEDIO)
                Console.WriteLine("DEMANDA MEDIA");
            else
                Console.WriteLine("DEMANDA BAJA");
        }
    }
}