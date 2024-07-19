using System; 

class Program // Define la clase principal del programa.
{
    static void Main() // Método principal que se ejecuta al iniciar el programa.
    {
        // Explicación sobre la importancia de usar nombres de variables descriptivos
        Console.WriteLine("Importancia de usar nombres de variables descriptivos:");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("1. Mejora la legibilidad del código.");
        Console.WriteLine("   - Los nombres descriptivos ayudan a otros programadores (o a ti mismo en el futuro) a entender rápidamente");
        Console.WriteLine("     qué representa una variable sin necesidad de leer toda la lógica del código.");
        Console.WriteLine("2. Facilita el mantenimiento del código.");
        Console.WriteLine("   - Cuando el código necesita ser modificado, los nombres claros hacen que sea más fácil identificar");
        Console.WriteLine("     qué partes del código afectan a qué variables.");
        Console.WriteLine("3. Reduce la posibilidad de errores.");
        Console.WriteLine("   - Nombres confusos pueden llevar a malentendidos y errores en la lógica del programa.");
        Console.WriteLine("-----------------------------------------------------");

        // Ejemplo de nombres de variables descriptivos
        double precioDelProducto = 19.99; // Precio de un producto
        int cantidadDeProductos = 5; // Cantidad de productos comprados
        double totalAPagar = precioDelProducto * cantidadDeProductos; // Total a pagar

        // Mostrar el resultado
        Console.WriteLine($"Precio del producto: {precioDelProducto}"); // Imprime el precio del producto.
        Console.WriteLine($"Cantidad de productos: {cantidadDeProductos}"); // Imprime la cantidad de productos.
        Console.WriteLine($"Total a pagar: {totalAPagar}"); // Imprime el total a pagar.

        // Esperar a que el usuario presione una tecla antes de cerrar la consola
        Console.WriteLine("Presiona cualquier tecla para continuar..."); // Indica al usuario que presione una tecla.
        Console.ReadKey(); // Espera a que el usuario presione una tecla.
    }
}
