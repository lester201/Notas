using System;

class Program
{
    static void Main()
    {
        // variables para almacenar las notas
        double nota1, nota2, nota3, nota4;

        // Leer las notas 
        Console.WriteLine("Ingrese la primera nota:");
        nota1 = LeerNota();

        Console.WriteLine("Ingrese la segunda nota:");
        nota2 = LeerNota();

        Console.WriteLine("Ingrese la tercera nota:");
        nota3 = LeerNota();

        Console.WriteLine("Ingrese la cuarta nota:");
        nota4 = LeerNota();

        // Calcular el promedio de las notas
        double promedio = (nota1 + nota2 + nota3 + nota4) / 4;

        // Mostrar el promedio
        Console.WriteLine($"El promedio de las notas es: {promedio:F2}");

        // Determinar y mostrar la observación del programa
        string observacion = ObtenerObservacion(promedio);
        Console.WriteLine($"Observación: {observacion}");
    }

    // Función para leer y validar una nota
    static double LeerNota()
    {
        double nota;
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out nota) && nota >= 0 && nota <= 100) // Suponer que las notas están entre 0 y 100
            {
                return nota;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor ingrese una nota válida (0 - 100):");
            }
        }
    }

    // Función para obtener la observación basada en el promedio del programa
    static string ObtenerObservacion(double promedio)
    {
        if (promedio < 70)
        {
            return "Reprobado";
        }
        else if (promedio >= 70 && promedio <= 80)
        {
            return "Bueno";
        }
        else if (promedio >= 81 && promedio <= 90)
        {
            return "Muy Bueno";
        }
        else if (promedio >= 91 && promedio <= 100)
        {
            return "Excelente";
        }
        else
        {
            return "Promedio fuera de rango"; //En la práctica esto no debería ocurrir
        }
    }
}
