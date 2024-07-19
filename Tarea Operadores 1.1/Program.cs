using System;

class Program
{
    static void Main()
    {
        // Declarar variables
        string nombre = "FERNANDO CAMACHO";
        int edad = 42;
        double estatura = 1.75; // en metros

        // Mostrar los valores en la consola
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Estatura: " + estatura + " metros");

        // Esperar a que el usuario presione una tecla antes de cerrar
        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadKey(); // Esto espera a que el usuario presione una tecla
    }
}

