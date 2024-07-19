using System; 
class Program // Define la clase principal del programa.
{
    static void Main() // Método principal que se ejecuta al iniciar el programa.
    {
        // Solicitar al usuario que ingrese el primer número
        Console.Write("Ingrese el primer número (dividendo): "); // Pide al usuario que ingrese el dividendo.
        int dividendo = Convert.ToInt32(Console.ReadLine()); // Lee y convierte la entrada a un número entero.

        // Solicitar al usuario que ingrese el segundo número
        Console.Write("Ingrese el segundo número (divisor): "); // Pide al usuario que ingrese el divisor.
        int divisor = Convert.ToInt32(Console.ReadLine()); // Lee y convierte la entrada a un número entero.

        // Verificar si el divisor es diferente de cero para evitar la división por cero
        if (divisor != 0) // Comprueba si el divisor es diferente de cero
        {
            // Calcular el residuo
            int residuo = dividendo % divisor; // El residuo se calcula como el residuo de la división.

            // Mostrar el resultado en la consola
            Console.WriteLine($"El residuo de {dividendo} dividido por {divisor} es: {residuo}"); // Imprime el resultado.
        }
        else // Si el divisor es cero
        {
            Console.WriteLine("Error: No se puede dividir entre cero."); // Mensaje de error para división por cero.
        }

        // Esperar a que el usuario presione una tecla antes de cerrar la consola
        Console.WriteLine("Presiona cualquier tecla para continuar..."); // Indica al usuario que presione una tecla.
        Console.ReadKey(); // Espera a que el usuario presione una tecla.
    }
}
