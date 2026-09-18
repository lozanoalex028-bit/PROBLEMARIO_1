using System;

class Program
{
    static void Main()
    {
        // Muestra el marco decorativo inicial con los datos del problema
        MostrarEncabezado("EJERCICIO 4: PRUEBA DE CORRIENTE DE ACTUADOR");

        // Variables para almacenar contadores y la suma total de las lecturas
        double sumaCorrientes = 0;
        int conteoNormales = 0;
        int conteoSobrecorrientes = 0;
        const int TOTAL_MEDICIONES = 8;

        Console.WriteLine("--- INICIO DE REGISTRO DE MEDICIONES ---");

        // Captura las 8 lecturas, evalúa cada valor y actualiza los contadores
        for (int i = 1; i <= TOTAL_MEDICIONES; i++)
        {
            Console.Write($"[Muestra {i:D2}/{TOTAL_MEDICIONES}] Ingrese corriente [A]: ");
            double lectura = Convert.ToDouble(Console.ReadLine());

            sumaCorrientes += lectura;

            // Determina si la medición individual está dentro del rango seguro (<= 5 A)
            if (lectura <= 5)
            {
                Console.WriteLine(" -> Estado: MEDICIÓN NORMAL\n");
                conteoNormales++;
            }
            else
            {
                Console.WriteLine(" -> Estado: SOBRECORRIENTE DETECTADA\n");
                conteoSobrecorrientes++;
            }
        }

        // Calcula la corriente promedio de la prueba
        double promedio = sumaCorrientes / TOTAL_MEDICIONES;

        // Evalúa si el actuador aprueba la prueba (cero sobrecorrientes)
        string estadoActuador = (conteoSobrecorrientes == 0)
            ? "ACTUADOR APROBADO"
            : "EL ACTUADOR REQUIERE REVISIÓN";

        // Despliega el resumen final estructurado en forma de tabla
        Console.WriteLine(new string('=', 45));
        Console.WriteLine("            RESULTADOS FINALES              ");
        Console.WriteLine(new string('=', 45));
        Console.WriteLine($"  Corriente promedio           : {promedio,6:F2} A");
        Console.WriteLine($"  Mediciones normales (<= 5 A) : {conteoNormales,6}");
        Console.WriteLine($"  Sobrecorrientes (> 5 A)      : {conteoSobrecorrientes,6}");
        Console.WriteLine(new string('-', 45));
        Console.WriteLine($"  DICTAMEN FINAL               : {estadoActuador}");
        Console.WriteLine(new string('=', 45));
    }

    // Dibuja la presentación visual e instrucciones en la consola
    static void MostrarEncabezado(string titulo)
    {
        Console.Clear();
        Console.WriteLine("=============================================");
        Console.WriteLine($"   {titulo}");
        Console.WriteLine("=============================================");
        Console.WriteLine("Descripción: Durante una prueba se realizan");
        Console.WriteLine("ocho mediciones de corriente de un actuador");
        Console.WriteLine("eléctrico para evaluar su funcionamiento.\n");
    }
}