using System;

namespace EST30_Ejercicios
{
    class Ej07_EST30
    {
        public static void Ejecutar()
        {
            const int TOTAL = 9;
            const int ALTO = 150;
            const int MEDIO = 60;

            int altos = 0, medios = 0, bajos = 0;

            for (int i = 1; i <= TOTAL; i++)
            {
                Console.Write("Valor del objeto " + i + ": ");
                int valor = int.Parse(Console.ReadLine());

                if (valor >= ALTO)
                {
                    Console.WriteLine("INVENTARIO ALTO");
                    altos++;
                }
                else if (valor >= MEDIO)
                {
                    Console.WriteLine("INVENTARIO MEDIO");
                    medios++;
                }
                else
                {
                    Console.WriteLine("INVENTARIO BAJO");
                    bajos++;
                }
            }

            Console.WriteLine("\nAltos: " + altos);
            Console.WriteLine("Medios: " + medios);
            Console.WriteLine("Bajos: " + bajos);
        }
    }
}