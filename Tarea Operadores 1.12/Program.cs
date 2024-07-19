using System; 
class Program // Define la clase principal del programa.
{
    static void Main() // Método principal que se ejecuta al iniciar el programa.
    {
        // Declarar una variable de tipo entero
        int edad = 25; // Declara una variable llamada 'edad' y le asigna un valor de 25.

        // Declarar una variable de tipo decimal
        double altura = 1.75; // Declara una variable llamada 'altura' y le asigna un valor de 1.75.

        // Declarar una variable de tipo cadena
        string nombre = "Juan"; // Declara una variable llamada 'nombre' y le asigna un valor de "Juan".

        // Mostrar los valores de las variables en la consola
        Console.WriteLine($"Nombre: {nombre}"); // Imprime el nombre.
        Console.WriteLine($"Edad: {edad} años"); // Imprime la edad.
        Console.WriteLine($"Altura: {altura} metros"); // Imprime la altura.

        // Esperar a que el usuario presione una tecla antes de cerrar la consola
        Console.WriteLine("Presiona cualquier tecla para continuar..."); // Indica al usuario que presione una tecla.
        Console.ReadKey(); // Espera a que el usuario presione una tecla.
    }
}
