using System;

namespace EST30_Ejercicios
{
    class Ej06_EST30
    {
        public static void Ejecutar()
        {
            const int TOTAL_DOCUMENTOS = 2500;
            const int UMBRAL = 500;

            int reserva = TOTAL_DOCUMENTOS;
            int jornadas = 0;

            Console.Write("Documentos entregados por jornada: ");
            int entrega = int.Parse(Console.ReadLine());

            while (reserva > 0)
            {
                reserva -= entrega;
                jornadas++;

                if (reserva < 0)
                    reserva = 0;

                Console.WriteLine("Jornada " + jornadas +
                                  " - Restantes: " + reserva);

                if (reserva > 0 && reserva < UMBRAL)
                    Console.WriteLine("ALERTA: reserva menor al 20%");
            }

            Console.WriteLine("\nTotal de jornadas: " + jornadas);
        }
    }
}