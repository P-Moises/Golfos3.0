using System;

namespace EST30_Ejercicios
{
    class Ej12_EST30
    {
        public static void Ejecutar()
        {
            const int TOTAL = 7;
            const int CRITICO = 1500;
            const int ALTO = 500;

            int confirmados = 0, pendientes = 0;

            for (int i = 1; i <= TOTAL; i++)
            {
                Console.Write("Hectareas del foco " + i + ": ");
                int hectareas = int.Parse(Console.ReadLine());

                if (hectareas >= CRITICO)
                {
                    Console.Write("Verificado? (1=Si, 2=No): ");
                    int verificado = int.Parse(Console.ReadLine());

                    if (verificado == 1)
                    {
                        Console.WriteLine("CRITICO CONFIRMADO");
                        confirmados++;
                    }
                    else
                    {
                        Console.WriteLine("CRITICO PENDIENTE");
                        pendientes++;
                    }
                }
                else if (hectareas >= ALTO)
                    Console.WriteLine("ALTO");
                else
                    Console.WriteLine("CONTROLADO");
            }

            Console.WriteLine("\nConfirmados: " + confirmados);
            Console.WriteLine("Pendientes: " + pendientes);
        }
    }
}