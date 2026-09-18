using System;
using System.Linq; // Permite el uso de métodos para arreglos

class Program
{
    static void Main()
    {
        // Despliega la presentación visual con el número y descripción del ejercicio
        MostrarEncabezado("EJERCICIO 2: PROMEDIO DE TEMPERATURAS");

        // Captura las 10 lecturas mediante una función y las almacena en un arreglo
        double[] lecturas = CapturarLecturas(10);

        // Realiza los cálculos de suma total y promedio
        double sumaTotal = lecturas.Sum();
        double promedio = sumaTotal / lecturas.Length;

        // Evalúa la condición para definir el mensaje del sistema
        string estadoSistema = (promedio <= 70) ? "TEMPERATURA NORMAL" : "ALERTA DE TEMPERATURA";

        // Muestra el reporte final estructurado con separadores
        Console.WriteLine("\n" + new string('-', 45));
        Console.WriteLine($"  SUMA TOTAL MEDIDA    : {sumaTotal,8:F2} °C");
        Console.WriteLine($"  PROMEDIO CALCULADO   : {promedio,8:F2} °C");
        Console.WriteLine(new string('-', 45));
        Console.WriteLine($"  ESTADO DEL SISTEMA   : {estadoSistema}");
        Console.WriteLine(new string('-', 45));
    }

    // Dibuja el marco decorativo e imprime el planteamiento en la consola
    static void MostrarEncabezado(string titulo)
    {
        Console.Clear();
        Console.WriteLine("=============================================");
        Console.WriteLine($"   {titulo}");
        Console.WriteLine("=============================================");
        Console.WriteLine("Descripción: Diseñe un programa que solicite");
        Console.WriteLine("diez mediciones de temperatura, las sume y");
        Console.WriteLine("calcule el promedio.\n");
    }

    // Solicita de forma iterativa el número de mediciones indicadas y devuelve un arreglo
    static double[] CapturarLecturas(int cantidad)
    {
        double[] mediciones = new double[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"[Muestreo {i + 1:D2}] Ingrese temperatura °C: ");
            mediciones[i] = Convert.ToDouble(Console.ReadLine());
        }

        return mediciones;
    }
}