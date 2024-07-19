using System; 
class Program // Define la clase principal del programa.
{
    static void Main() // Método principal que se ejecuta al iniciar el programa.
    {
        // Inicializar una variable de tipo entero con un valor predeterminado
        int edad = 30; // Inicializa la variable 'edad' con el valor predeterminado de 30.

        // Inicializar una variable de tipo decimal con un valor predeterminado
        double altura = 1.80; // Inicializa la variable 'altura' con el valor predeterminado de 1.80.

        // Inicializar una variable de tipo cadena con un valor predeterminado
        string nombre = "Ana"; // Inicializa la variable 'nombre' con el valor predeterminado de "Ana".

        // Mostrar los valores de las variables en la consola
        Console.WriteLine($"Nombre: {nombre}"); // Imprime el nombre.
        Console.WriteLine($"Edad: {edad} años"); // Imprime la edad.
        Console.WriteLine($"Altura: {altura} metros"); // Imprime la altura.

        // Esperar a que el usuario presione una tecla antes de cerrar la consola
        Console.WriteLine("Presiona cualquier tecla para continuar..."); // Indica al usuario que presione una tecla.
        Console.ReadKey(); // Espera a que el usuario presione una tecla.
    }
}
