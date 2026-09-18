using System;

class Program
{
    static void Main()
    {
        // Muestra la presentación del ejercicio con marco decorativo
        MostrarEncabezado("EJERCICIO 5: ANÁLISIS DE VIBRACIÓN DE MOTORES");

        // Variables globales para contadores del informe final
        int totalMotores = 0;
        int normalesCount = 0;
        int mantenimientoCount = 0;
        bool procesarOtro = true;

        // Bucle interactivo para analizar múltiples motores hasta que el usuario decida salir
        while (procesarOtro)
        {
            Console.WriteLine("\n--- DATOS DEL EQUIPO ---");
            Console.Write("-> Identificador/Nombre del motor: ");
            string nombreMotor = Console.ReadLine();

            // Procesa las 4 lecturas de vibración y calcula su promedio
            double promedioVibracion = CapturarYCalcularPromedio(4);

            // Clasifica el estado del motor según el nivel de vibración (límite 4.5 mm/s)
            bool esNormal = promedioVibracion <= 4.5;

            // Muestra la ficha técnica del motor analizado
            Console.WriteLine("\n" + new string('-', 45));
            Console.WriteLine($"  MOTOR EVALUADO      : {nombreMotor}");
            Console.WriteLine($"  PROMEDIO VIBRACIÓN  : {promedioVibracion,6:F2} mm/s");
            Console.WriteLine($"  DIAGNÓSTICO         : {(esNormal ? "FUNCIONAMIENTO NORMAL" : "REQUIERE MANTENIMIENTO")}");
            Console.WriteLine(new string('-', 45));

            // Actualiza los contadores globales
            totalMotores++;
            if (esNormal) normalesCount++; else mantenimientoCount++;

            // Pregunta al usuario si desea evaluar un motor adicional
            Console.Write("\n¿Desea analizar otro motor? (s/n): ");
            string respuesta = Console.ReadLine().Trim().ToLower();
            procesarOtro = (respuesta == "s");
        }

        // Muestra el resumen global de la inspección
        Console.WriteLine("\n" + new string('=', 45));
        Console.WriteLine("           RESUMEN GENERAL DE INSPECCIÓN     ");
        Console.WriteLine(new string('=', 45));
        Console.WriteLine($"  Total de motores evaluados : {totalMotores,4}");
        Console.WriteLine($"  Funcionamiento normal      : {normalesCount,4}");
        Console.WriteLine($"  Requieren mantenimiento    : {mantenimientoCount,4}");
        Console.WriteLine(new string('=', 45));
    }

    // Dibuja el marco decorativo y la descripción del ejercicio
    static void MostrarEncabezado(string titulo)
    {
        Console.Clear();
        Console.WriteLine("=============================================");
        Console.WriteLine($"   {titulo}");
        Console.WriteLine("=============================================");
        Console.WriteLine("Descripción: Diseñe un programa que permita");
        Console.WriteLine("analizar la vibración de varios motores");
        Console.WriteLine("y determine su estado operativo.\n");
    }

    // Solicita de forma iterativa el número de mediciones y retorna el promedio
    static double CapturarYCalcularPromedio(int numMediciones)
    {
        double sumaTotal = 0;
        for (int i = 1; i <= numMediciones; i++)
        {
            Console.Write($"  [Muestra {i:D2}/{numMediciones}] Vibración [mm/s]: ");
            sumaTotal += Convert.ToDouble(Console.ReadLine());
        }
        return sumaTotal / numMediciones;
    }
}