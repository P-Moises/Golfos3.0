using System;

namespace EST30_Ejercicios
{
    class Ej10_EST30
    {
        public static void Ejecutar()
        {
            const int TOTAL = 9;
            const double META = 100;

            int contador = 1;
            double suma = 0;

            while (contador <= TOTAL)
            {
                Console.Write("Cantidad del articulo " + contador + ": ");
                double valor = double.Parse(Console.ReadLine());

                suma += valor;
                contador++;
            }

            double promedio = suma / TOTAL;

            Console.WriteLine("\nTotal: " + suma);
            Console.WriteLine("Promedio: " + promedio);

            if (promedio >= META)
                Console.WriteLine("ACEPTABLE");
            else
                Console.WriteLine("REQUIERE INTERVENCION");
        }
    }
}