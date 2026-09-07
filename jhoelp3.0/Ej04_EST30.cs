using System;

namespace EST30_Ejercicios
{
    class Ej04_EST30
    {
        public static void Ejecutar()
        {
            const string OPCION1 = "1. Ver registro de parcelas";
            const string OPCION2 = "2. Ver meta del periodo";
            const string OPCION3 = "3. Ver rango de litros ahorrados";
            const string OPCION4 = "4. Salir";

            int opcion;

            do
            {
                Console.WriteLine("\nMENU DE CONSULTAS");
                Console.WriteLine(OPCION1);
                Console.WriteLine(OPCION2);
                Console.WriteLine(OPCION3);
                Console.WriteLine(OPCION4);

                Console.Write("Seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                    Console.WriteLine("Mostrando registro de parcelas.");
                else if (opcion == 2)
                    Console.WriteLine("Mostrando meta del periodo.");
                else if (opcion == 3)
                    Console.WriteLine("Mostrando rango de litros ahorrados.");
                else if (opcion == 4)
                    Console.WriteLine("Saliendo...");
                else
                    Console.WriteLine("La opcion no existe.");

            } while (opcion != 4);
        }
    }
}