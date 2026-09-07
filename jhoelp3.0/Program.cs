using System;

namespace EST30_Ejercicios
{
    class Ej01_EST30
    {
        public static void Main()
        {
            Ej02_EST30.Ejecutar();
        }

        public static void Ejecutar()
        {
            const int TOTAL_TRANSACCIONES = 9;
            int contador = 1;

            while (contador <= TOTAL_TRANSACCIONES)
            {
                Console.WriteLine("Transacción QR registrada N° " + contador);
                contador++;
            }

            Console.WriteLine("Total registrado: " + TOTAL_TRANSACCIONES);
        }
    }
}