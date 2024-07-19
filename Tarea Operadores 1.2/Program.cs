using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese dos números enteros
        Console.WriteLine("Ingrese el primer número entero:");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número entero:");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        // Determinar el mayor y el menor
        int mayor, menor;

        if (numero1 > numero2)
        {
            mayor = numero1;
            menor = numero2;
        }
        else if (numero1 < numero2)
        {
            mayor = numero2;
            menor = numero1;
        }
        else
        {
            Console.WriteLine("Ambos números son iguales.");
            return; // Salir del programa si son iguales
        }

        // Mostrar el resultado
        Console.WriteLine("El número mayor es: " + mayor);
        Console.WriteLine("El número menor es: " + menor);

        // Esperar a que el usuario presione una tecla antes de cerrar
        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadKey();
    }
}
