using System; // Importa el espacio de nombres System, que contiene clases básicas como Console.

class Program // Define la clase principal del programa.
{
    static void Main() // Método principal que se ejecuta al iniciar el programa.
    {
        // Solicitar al usuario que ingrese la longitud de un lado del cuadrado
        Console.Write("Ingrese la longitud de un lado del cuadrado: "); // Pide al usuario que ingrese un valor.

        // Leer la entrada del usuario y convertirla a un número decimal
        double lado = Convert.ToDouble(Console.ReadLine()); // Convierte la entrada a un número decimal.

        // Calcular el área del cuadrado
        double area = lado * lado; // El área se calcula como lado al cuadrado.

        // Calcular el perímetro del cuadrado
        double perimetro = 4 * lado; // El perímetro se calcula como cuatro veces la longitud del lado.

        // Mostrar los resultados en la consola
        Console.WriteLine($"El área del cuadrado es: {area}"); // Imprime el área calculada.
        Console.WriteLine($"El perímetro del cuadrado es: {perimetro}"); // Imprime el perímetro calculado.

        // Esperar a que el usuario presione una tecla antes de cerrar la consola
        Console.WriteLine("Presiona cualquier tecla para continuar..."); // Indica al usuario que presione una tecla.
        Console.ReadKey(); // Espera a que el usuario presione una tecla.
    }
}
