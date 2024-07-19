using System; 
class Program // Define la clase principal del programa.
{
    static void Main() // Método principal que se ejecuta al iniciar el programa.
    {
        // Declarar una variable normal
        int numero = 10; // Inicializa la variable con un valor de 10.

        // Mostrar el valor inicial de la variable
        Console.WriteLine($"El valor inicial de la variable 'numero' es: {numero}"); // Imprime el valor inicial.

        // Modificar el valor de la variable
        numero = 20; // Cambia el valor de la variable a 20.

        // Mostrar el nuevo valor de la variable
        Console.WriteLine($"El nuevo valor de la variable 'numero' es: {numero}"); // Imprime el nuevo valor.

        // Esperar a que el usuario presione una tecla antes de cerrar la consola
        Console.WriteLine("Presiona cualquier tecla para continuar..."); // Indica al usuario que presione una tecla.
        Console.ReadKey(); // Espera a que el usuario presione una tecla.
    }
}
