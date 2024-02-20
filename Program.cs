using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno
            // y luego calcule y emita por pantalla el promedio final.
            float n1, n2, n3, promedio;
            System.Console.WriteLine("Ingrese la primera nota");
            n1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese la segunda nota");
            n2 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese la tercera nota");
            n3 = float.Parse(Console.ReadLine());
            promedio = (n1 + n2 + n3) / 3;
            Console.WriteLine("El promedio de nota es: " + promedio.ToString("0.00"));
        }
    }
}
