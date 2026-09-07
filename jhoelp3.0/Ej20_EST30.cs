using System;

namespace EST30_Ejercicios
{
    class Ej20_EST30
    {
        public static void Ejecutar()
        {
            const int SALIR = 4;
            const int CANTIDAD = 5;
            const int MINIMO = 5;
            const int MAXIMO = 60;
            const int ENTREGA = 20;
            const double COMPLETA = 45;
            const double BREVE = 25;

            int opcion;
            int cantidadDatos = 0;
            double total = 0;
            bool hayDatos = false;

            do
            {
                Console.WriteLine("\n1. Carga de teleconsultas");
                Console.WriteLine("2. Reporte de clasificacion");
                Console.WriteLine("3. Simulacion de cobertura");
                Console.WriteLine("4. Salir");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    for (int i = 1; i <= CANTIDAD; i++)
                    {
                        int valor;

                        do
                        {
                            Console.Write("Teleconsulta " + i + " (5 a 60): ");
                            valor = int.Parse(Console.ReadLine());

                            if (valor < MINIMO || valor > MAXIMO)
                                Console.WriteLine("Valor invalido.");

                        } while (valor < MINIMO || valor > MAXIMO);

                        total += valor;
                        cantidadDatos++;
                    }

                    hayDatos = true;
                    Console.WriteLine("Total cargado: " + total);
                }
                else if (opcion == 2)
                {
                    if (!hayDatos)
                    {
                        Console.WriteLine("No hay datos cargados.");
                    }
                    else
                    {
                        double promedio = total / cantidadDatos;
                        Console.WriteLine("Promedio: " + promedio);

                        if (promedio >= COMPLETA)
                            Console.WriteLine("CONSULTA COMPLETA");
                        else if (promedio >= BREVE)
                            Console.WriteLine("CONSULTA BREVE");
                        else
                            Console.WriteLine("CONSULTA INCOMPLETA");
                    }
                }
                else if (opcion == 3)
                {
                    if (!hayDatos)
                    {
                        Console.WriteLine("No hay datos cargados.");
                    }
                    else
                    {
                        double restante = total;
                        int jornadas = 0;

                        while (restante > 0)
                        {
                            restante -= ENTREGA;
                            jornadas++;
                        }

                        Console.WriteLine("Jornadas cubiertas: " + jornadas);
                    }
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("\nRESUMEN");
                    Console.WriteLine("Datos cargados: " + cantidadDatos);
                    Console.WriteLine("Total: " + total);
                }
                else
                {
                    Console.WriteLine("Opcion no valida.");
                }

            } while (opcion != SALIR);
        }
    }
}