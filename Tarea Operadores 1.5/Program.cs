using System; // Importa el espacio de nombres System, que contiene clases básicas como Console.

class Program // Define la clase principal del programa.
{
    static void Main() // Método principal que se ejecuta al iniciar el programa.
    {
        // Solicitar al usuario que ingrese el radio de la esfera
        Console.Write("Ingrese el radio de la esfera: "); // Pide al usuario que ingrese el radio.

        // Leer la entrada del usuario y convertirla a un número decimal
        double radio = Convert.ToDouble(Console.ReadLine()); // Convierte la entrada a un número decimal.

        // Calcular el área de la esfera
        double area = 4 * Math.PI * Math.Pow(radio, 2); // El área se calcula como 4 * π * radio^2.

        // Calcular el volumen de la esfera
        double volumen = (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3); // El volumen se calcula como (4/3) * π * radio^3.

        // Mostrar los resultados en la consola
        Console.WriteLine($"El área de la esfera es: {area}"); // Imprime el área calculada.
        Console.WriteLine($"El volumen de la esfera es: {volumen}"); // Imprime el volumen calculado.

        // Esperar a que el usuario presione una tecla antes de cerrar la consola
        Console.WriteLine("Presiona cualquier tecla para continuar..."); // Indica al usuario que presione una tecla.
        Console.ReadKey(); // Espera a que el usuario presione una tecla.
    }
}
