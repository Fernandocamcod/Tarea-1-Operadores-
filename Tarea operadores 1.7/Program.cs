using System; // Importa el espacio de nombres System, que contiene clases básicas como Console.

class Program // Define la clase principal del programa.
{
    static void Main() // Método principal que se ejecuta al iniciar el programa.
    {
        // Solicitar al usuario que ingrese el primer número
        Console.Write("Ingrese el primer número: "); // Pide al usuario que ingrese el primer número.
        double numero1 = Convert.ToDouble(Console.ReadLine()); // Lee y convierte la entrada a un número decimal.

        // Solicitar al usuario que ingrese el segundo número
        Console.Write("Ingrese el segundo número: "); // Pide al usuario que ingrese el segundo número.
        double numero2 = Convert.ToDouble(Console.ReadLine()); // Lee y convierte la entrada a un número decimal.

        // Comparar los dos números
        if (numero1 > numero2) // Comprueba si el primer número es mayor que el segundo
        {
            Console.WriteLine($"{numero1} es mayor que {numero2}."); // Imprime el resultado si el primer número es mayor.
        }
        else if (numero1 < numero2) // Comprueba si el primer número es menor que el segundo
        {
            Console.WriteLine($"{numero1} es menor que {numero2}."); // Imprime el resultado si el primer número es menor.
        }
        else // Si los números son iguales
        {
            Console.WriteLine($"{numero1} es igual a {numero2}."); // Imprime el resultado si los números son iguales.
        }

        // Esperar a que el usuario presione una tecla antes de cerrar la consola
        Console.WriteLine("Presiona cualquier tecla para continuar..."); // Indica al usuario que presione una tecla.
        Console.ReadKey(); // Espera a que el usuario presione una tecla.
    }
}
