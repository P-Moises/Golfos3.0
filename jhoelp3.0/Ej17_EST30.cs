using System;

namespace EST30_Ejercicios
{
    class Ej17_EST30
    {
        public static void Ejecutar()
        {
            const int CENTINELA = -1;
            const double ALTO = 25;
            const double MEDIO = 12;

            int contador = 0;
            double suma = 0;

            Console.Write("Rampas en buen estado (-1 para terminar): ");
            double valor = double.Parse(Console.ReadLine());

            while (valor != CENTINELA)
            {
                suma += valor;
                contador++;

                Console.Write("Rampas en buen estado (-1 para terminar): ");
                valor = double.Parse(Console.ReadLine());
            }

            if (contador == 0)
            {
                Console.WriteLine("No hubo datos cargados.");
            }
            else
            {
                double promedio = suma / contador;

                Console.WriteLine("\nEsquinas evaluadas: " + contador);
                Console.WriteLine("Suma: " + suma);
                Console.WriteLine("Promedio: " + promedio);

                if (promedio >= ALTO)
                    Console.WriteLine("PROMEDIO ALTO");
                else if (promedio >= MEDIO)
                    Console.WriteLine("PROMEDIO MEDIO");
                else
                    Console.WriteLine("PROMEDIO BAJO");
            }
        }
    }
}