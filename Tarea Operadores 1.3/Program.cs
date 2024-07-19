using System; // Importa el espacio de nombres System, que contiene clases básicas como Console.

class Program // Define la clase principal del programa.
{
    static void Main() // Método principal que se ejecuta al iniciar el programa.
    {
        // Solicitar al usuario que elija el tipo de conversión
        Console.WriteLine("Seleccione la conversión:"); // Muestra un mensaje en la consola.
        Console.WriteLine("1. Celsius a Fahrenheit"); // Opción para convertir Celsius a Fahrenheit.
        Console.WriteLine("2. Fahrenheit a Celsius"); // Opción para convertir Fahrenheit a Celsius.
        Console.Write("Ingrese su opción (1 o 2): "); // Pide al usuario que ingrese su opción.

        // Lee la opción ingresada por el usuario y la convierte a un entero
        int opcion = Convert.ToInt32(Console.ReadLine()); // Convierte la entrada de texto a un entero.

        // Realizar la conversión según la opción seleccionada
        if (opcion == 1) // Comprueba si la opción es 1
        {
            Console.Write("Ingrese la temperatura en Celsius: "); // Pide al usuario que ingrese la temperatura en Celsius.
            double celsius = Convert.ToDouble(Console.ReadLine()); // Convierte la entrada a un número decimal.
            // Calcula la temperatura en Fahrenheit usando la fórmula
            double fahrenheit = (celsius * 9 / 5) + 32; // Realiza la conversión de Celsius a Fahrenheit.
            // Muestra el resultado de la conversión
            Console.WriteLine($"{celsius} °C es igual a {fahrenheit} °F"); // Imprime el resultado en la consola.
        }
        else if (opcion == 2) // Comprueba si la opción es 2
        {
            Console.Write("Ingrese la temperatura en Fahrenheit: "); // Pide al usuario que ingrese la temperatura en Fahrenheit.
            double fahrenheit = Convert.ToDouble(Console.ReadLine()); // Convierte la entrada a un número decimal.
            // Calcula la temperatura en Celsius usando la fórmula
            double celsius = (fahrenheit - 32) * 5 / 9; // Realiza la conversión de Fahrenheit a Celsius.
            // Muestra el resultado de la conversión
            Console.WriteLine($"{fahrenheit} °F es igual a {celsius} °C"); // Imprime el resultado en la consola.
        }
        else // Si la opción no es ni 1 ni 2
        {
            Console.WriteLine("Opción no válida. Por favor, seleccione 1 o 2."); // Muestra un mensaje de error.
        }

        // Esperar a que el usuario presione una tecla antes de cerrar la consola
        Console.WriteLine("Presiona cualquier tecla para continuar..."); // Indica al usuario que presione una tecla.
        Console.ReadKey(); // Espera a que el usuario presione una tecla.
    }
}
