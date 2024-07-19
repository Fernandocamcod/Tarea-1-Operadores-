using System; // Importa el espacio de nombres System, que contiene clases básicas como Console.

class Program 
{
    static void Main() // Método principal que se ejecuta al iniciar el programa.
    {
        // Declarar una variable constante
        const double PI = 3.14159; // Declara una constante para el valor de PI.

        // Declarar una variable normal
        double radio = 5.0; // Declara una variable normal y asigna un valor.

        // Mostrar los valores en la consola
        Console.WriteLine($"El valor de PI es: {PI}"); // Imprime el valor de la constante.
        Console.WriteLine($"El radio del círculo es: {radio}"); // Imprime el valor de la variable normal.

        // Esperar a que el usuario presione una tecla antes de cerrar la consola
        Console.WriteLine("Presiona cualquier tecla para continuar..."); // Indica al usuario que presione una tecla.
        Console.ReadKey(); // Espera a que el usuario presione una tecla.
    }
}
