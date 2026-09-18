using System;

class Program
{
    static void Main()
    {
        // Muestra el título y la descripción inicial en la consola
        ImprimirEncabezado("CÁLCULO DE POTENCIA ELÉCTRICA - MOTOR CD");

        // Solicita y captura los valores ingresados por el usuario
        double voltaje = LeerNumero("-> Ingrese el voltaje [V]: ");
        double corriente = LeerNumero("-> Ingrese la corriente [A]: ");

        // Calcula la potencia y determina si supera el límite de 120 W
        double potencia = CalcularPotencia(voltaje, corriente);
        bool esConsumoAlto = potencia > 120;

        // Imprime el resultado final formateado con bordes decorativos
        Console.WriteLine("\n" + new string('=', 45));
        Console.WriteLine($"  POTENCIA TOTAL CALCULADA : {potencia,8:F2} W");
        Console.WriteLine(new string('=', 45));

        // Muestra el mensaje de estado según el nivel de consumo
        string estado = esConsumoAlto ? "ADVERTENCIA: CONSUMO ELEVADO" : "CONSUMO NORMAL";
        Console.WriteLine($"  ESTADO DEL SISTEMA       : {estado}");
        Console.WriteLine(new string('=', 45));
    }

    // Limpia la pantalla y dibuja el marco del encabezado
    static void ImprimirEncabezado(string titulo)
    {
        Console.Clear();
        Console.WriteLine("=============================================");
        Console.WriteLine($"   {titulo}");
        Console.WriteLine("=============================================");
        Console.WriteLine("Descripción: Diseñe un programa que solicite");
        Console.WriteLine("el voltaje y la corriente consumida por un");
        Console.WriteLine("motor de CD y calcule la potencia eléctrica.\n");
    }

    // Muestra un mensaje en consola y convierte la entrada del usuario a decimal (double)
    static double LeerNumero(string mensaje)
    {
        Console.Write(mensaje);
        return Convert.ToDouble(Console.ReadLine());
    }

    // Aplica la fórmula de potencia eléctrica: P = V * I
    static double CalcularPotencia(double v, double i) => v * i;
