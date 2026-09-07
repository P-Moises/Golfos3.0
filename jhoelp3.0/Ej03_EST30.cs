using System;

namespace EST30_Ejercicios
{
    class Ej03_EST30
    {
        public static void Ejecutar()
        {
            const int MINIMO = 5;
            const int MAXIMO = 200;

            int segundos;

            do
            {
                Console.Write("Ingrese los segundos de espera promedio: ");
                segundos = int.Parse(Console.ReadLine());

                if (segundos < MINIMO || segundos > MAXIMO)
                {
                    Console.WriteLine("ERROR: El valor debe estar entre 5 y 200 segundos.");
                }

            } while (segundos < MINIMO || segundos > MAXIMO);

            Console.WriteLine("Dato valido registrado: " + segundos + " segundos.");
        }
    }
}