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

        // Realizar las operaciones aritméticas
        double suma = numero1 + numero2; // Calcula la suma de los dos números.
        double resta = numero1 - numero2; // Calcula la resta de los dos números.
        double multiplicacion = numero1 * numero2; // Calcula la multiplicación de los dos números.

        // Verificar si el segundo número es diferente de cero para evitar la división por cero
        double division;
        if (numero2 != 0)
        {
            division = numero1 / numero2; // Calcula la división de los dos números.
            Console.WriteLine($"La división de {numero1} entre {numero2} es: {division}"); // Imprime el resultado de la división.
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir entre cero."); // Mensaje de error si el segundo número es cero.
        }

        // Mostrar los resultados de las otras operaciones
        Console.WriteLine($"La suma de {numero1} y {numero2} es: {suma}"); // Imprime el resultado de la suma.
        Console.WriteLine($"La resta de {numero1} y {numero2} es: {resta}"); // Imprime el resultado de la resta.
        Console.WriteLine($"La multiplicación de {numero1} y {numero2} es: {multiplicacion}"); // Imprime el resultado de la multiplicación.

        // Esperar a que el usuario presione una tecla antes de cerrar la consola
        Console.WriteLine("Presiona cualquier tecla para continuar..."); // Indica al usuario que presione una tecla.
        Console.ReadKey(); // Espera a que el usuario presione una tecla.
    }
}
