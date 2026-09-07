using System;

namespace EST30_Ejercicios
{
    class Ej14_EST30
    {
        public static void Ejecutar()
        {
            const int ZONAS = 2;
            const int DIAS = 4;
            const int UMBRAL = 400;

            int totalGeneral = 0;

            for (int zona = 1; zona <= ZONAS; zona++)
            {
                int subtotal = 0;

                for (int dia = 1; dia <= DIAS; dia++)
                {
                    Console.Write("Zona " + zona + ", dia " + dia + ": ");
                    int hectareas = int.Parse(Console.ReadLine());

                    subtotal += hectareas;
                }

                Console.WriteLine("Subtotal zona " + zona + ": " + subtotal);

                if (subtotal > UMBRAL)
                    Console.WriteLine("DESMONTE GRAVE");
                else
                    Console.WriteLine("DESMONTE LEVE");

                totalGeneral += subtotal;
            }

            Console.WriteLine("\nTotal general: " + totalGeneral);
        }
    }
}