using System;

class Program
{
    static void Main()
    {
        // Muestra la presentación del ejercicio con marco decorativo
        MostrarPantallaInicio("EJERCICIO 3: SIMULADOR DE CARGA DE BATERÍA");

        // Captura el voltaje inicial y el paso de carga por iteración
        double voltajeActual = ObtenerDato("-> Ingrese el voltaje inicial [V]: ");
        double incrementoCarga = ObtenerDato("-> Ingrese el incremento por ciclo [V]: ");

        // Valida que el incremento sea positivo para evitar ciclos infinitos
        if (incrementoCarga <= 0)
        {
            Console.WriteLine("\n[ERROR] El incremento debe ser un valor positivo mayor a cero.");
            return;
        }

        // Ejecuta la simulación de carga hasta alcanzar el límite de 12.6V
        SimularCargaBateria(voltajeActual, incrementoCarga, 12.6);
    }

    // Dibuja el marco decorativo y el planteamiento del problema
    static void MostrarPantallaInicio(string titulo)
    {
        Console.Clear();
        Console.WriteLine("=============================================");
        Console.WriteLine($"   {titulo}");
        Console.WriteLine("=============================================");
        Console.WriteLine("Descripción: Diseñe un programa que simule");
        Console.WriteLine("la carga de una batería de 12.6 V mediante");
        Console.WriteLine("un ciclo while.\n");
    }

    // Solicita un número en la consola y lo convierte a tipo decimal (double)
    static double ObtenerDato(string mensaje)
    {
        Console.Write(mensaje);
        return Convert.ToDouble(Console.ReadLine());
    }

    // Procesa el ciclo de incremento de voltaje hasta tope máximo
    static void SimularCargaBateria(double voltaje, double incremento, double limite)
    {
        int paso = 0;
        Console.WriteLine("\n--- INICIANDO PROCESO DE CARGA ---");

        // Incrementa el voltaje mientras esté por debajo del límite especificado
        while (voltaje < limite)
        {
            paso++;
            voltaje += incremento;

            // Ajusta el voltaje al valor límite exacto si se sobrepasa
            if (voltaje > limite)
            {
                voltaje = limite;
            }

            Console.WriteLine($"  [Ciclo {paso:D2}] -> Voltaje registrado: {voltaje,6:F2} V");
        }

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("  ESTADO: La batería ha alcanzado los 12.6 V.");
        Console.WriteLine("---------------------------------------------");
    }
}