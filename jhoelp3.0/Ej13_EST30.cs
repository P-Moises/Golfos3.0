using System;

namespace EST30_Ejercicios
{
    class Ej13_EST30
    {
        public static void Ejecutar()
        {
            const int META = 200;

            int acumulado = 0;
            int periodos = 0;

            while (acumulado < META)
            {
                Console.Write("Horas del periodo: ");
                int horas = int.Parse(Console.ReadLine());

                acumulado += horas;
                periodos++;

                if (horas == 0)
                    Console.WriteLine("Periodo improductivo.");
                else
                    Console.WriteLine("Periodo registrado.");

                if (acumulado < META)
                    Console.WriteLine("Faltan: " + (META - acumulado) + " horas.");
            }

            Console.WriteLine("\nTotal acumulado: " + acumulado);
            Console.WriteLine("Excedente: " + (acumulado - META));
            Console.WriteLine("Periodos usados: " + periodos);
        }
    }
}