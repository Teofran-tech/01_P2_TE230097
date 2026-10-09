
using System;

// Clase que representa al motor eléctrico
class Motor
{
    // Propiedades del motor
    public string identificador = "";
    public double voltaje;
    public double corriente;
    public double potencia;
    public string estadoConsumo = "";

    // Método para capturar los datos del motor
    public void CapturarDatos()
    {
        Console.WriteLine("EVALUACION DEL CONSUMO DE UN MOTOR");
        Console.Write("Identificador del motor: ");
        identificador = Console.ReadLine() ?? "";

        Console.Write("Voltaje de alimentacion (V): ");
        voltaje = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Corriente consumida (A): ");
        corriente = double.Parse(Console.ReadLine() ?? "0");
    }

    // Método para calcular la potencia eléctrica
    public void CalcularPotencia()
    {
        potencia = voltaje * corriente;
    }

    // Método para evaluar el consumo
    public void EvaluarConsumo()
    {
        if (potencia <= 120)
        {
            estadoConsumo = "Consumo normal";
        }
        else
        {
            estadoConsumo = "Consumo elevado";
        }
    }

    // Método para mostrar los resultados
    public void MostrarResultados()
    {
        Console.WriteLine("\n--- RESULTADOS ---");
        Console.WriteLine("Motor: " + identificador);
        Console.WriteLine("Potencia: " + potencia + " W");
        Console.WriteLine("Estado: " + estadoConsumo);
    }
}

// Clase principal del programa
class Program
{
    static void Main()
    {
        // Creación del objeto
        Motor motor1 = new Motor();

        // Llamada a los métodos
        motor1.CapturarDatos();
        motor1.CalcularPotencia();
        motor1.EvaluarConsumo();
        motor1.MostrarResultados();

        Console.WriteLine("\nPresiona una tecla para terminar.");
        Console.ReadKey();
    }
}
