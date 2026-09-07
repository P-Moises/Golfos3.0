using System;

namespace EST30_Ejercicios
{
    class Ej02_EST30
    {
        public static void Ejecutar()
        {
            const int TOTAL_SENSORES = 5;
            const int META = 500;

            int contador = 1;
            int suma = 0;

            while (contador <= TOTAL_SENSORES)
            {
                Console.Write("Ingrese humedad del sensor " + contador + ": ");
                int humedad = int.Parse(Console.ReadLine());

                suma += humedad;
                contador++;
            }

            Console.WriteLine("Total acumulado: " + suma + "%");

            if (suma >= META)
                Console.WriteLine("Se alcanzo la meta.");
            else
                Console.WriteLine("No se alcanzo la meta.");
        }
    }
}