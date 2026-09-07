using System;

namespace EST30_Ejercicios
{
    class Ej15_EST30
    {
        public static void Ejecutar()
        {
            const int CODIGO = 2021;
            const int MAX_INTENTOS = 4;

            int intentos = MAX_INTENTOS;
            bool acceso = false;

            do
            {
                Console.Write("Ingrese el codigo: ");
                int codigo = int.Parse(Console.ReadLine());

                if (codigo == CODIGO)
                {
                    acceso = true;

                    Console.Write("Permiso (1=Consulta, 2=Edicion): ");
                    int permiso = int.Parse(Console.ReadLine());

                    if (permiso == 1)
                        Console.WriteLine("Acceso de CONSULTA");
                    else if (permiso == 2)
                        Console.WriteLine("Acceso de EDICION");
                    else
                        Console.WriteLine("Permiso no valido");
                }
                else
                {
                    intentos--;
                    Console.WriteLine("Codigo incorrecto");
                    Console.WriteLine("Intentos restantes: " + intentos);
                }

            } while (intentos > 0 && !acceso);

            if (!acceso)
                Console.WriteLine("Cuenta bloqueada");
        }
    }
}