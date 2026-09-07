using System;

namespace EST30_Ejercicios
{
    class Ej11_EST30
    {
        public static void Ejecutar()
        {
            const int SALIR = 3;
            int opcion, urgentes = 0;

            do
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1. Registrar operacion");
                Console.WriteLine("2. Consultar meta");
                Console.WriteLine("3. Salir");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("Zona (1=Norte, 2=Sur): ");
                    int zona = int.Parse(Console.ReadLine());

                    if (zona == 1 || zona == 2)
                    {
                        Console.Write("¿Es urgente? (1=Si, 2=No): ");
                        int urgente = int.Parse(Console.ReadLine());

                        if (urgente == 1)
                        {
                            urgentes++;
                            Console.WriteLine("Operacion URGENTE registrada.");
                        }
                        else
                            Console.WriteLine("Operacion normal registrada.");
                    }
                    else
                        Console.WriteLine("Zona no valida.");
                }
                else if (opcion == 2)
                    Console.WriteLine("Mostrando meta del periodo.");
                else if (opcion != 3)
                    Console.WriteLine("Opcion no valida.");

            } while (opcion != SALIR);

            Console.WriteLine("\nRegistros urgentes: " + urgentes);
        }
    }
}