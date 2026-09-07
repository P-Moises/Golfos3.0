using System;

namespace EST30_Ejercicios
{
    class Ej09_EST30
    {
        public static void Ejecutar()
        {
            const int TOTAL = 7;

            double maximo = 0, minimo = 0;
            int tramoMax = 0, tramoMin = 0;

            for (int i = 1; i <= TOTAL; i++)
            {
                Console.Write("Kilometros del tramo " + i + ": ");
                double km = double.Parse(Console.ReadLine());

                if (i == 1)
                {
                    maximo = minimo = km;
                    tramoMax = tramoMin = i;
                }
                else
                {
                    if (km > maximo)
                    {
                        maximo = km;
                        tramoMax = i;
                    }

                    if (km < minimo)
                    {
                        minimo = km;
                        tramoMin = i;
                    }
                }
            }

            Console.WriteLine("\nMaximo: " + maximo + " - Tramo " + tramoMax);
            Console.WriteLine("Minimo: " + minimo + " - Tramo " + tramoMin);
        }
    }
}