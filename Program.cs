using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAlgoritmosOrdenamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                // Obtener datos del usuario
                Console.WriteLine("Ingrese los datos separados por comas:");
                int[] data = ParseInput(Console.ReadLine());

                // Seleccionar algoritmo
                Console.WriteLine("Seleccione un algoritmo de ordenamiento:");
                Console.WriteLine("1. Shell Sort");
                Console.WriteLine("2. Selection Sort");

                int choice = int.Parse(Console.ReadLine());

                // Crear una instancia del algoritmo seleccionado
                var selectedAlgorithm = GetSortingAlgorithm(choice);

                // Medir el tiempo de ejecución
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();

                // Llamar al método de ordenamiento
                selectedAlgorithm.Sort(data);

                stopwatch.Stop();
                Console.WriteLine($"Tiempo de ejecución: {stopwatch.ElapsedMilliseconds} ms");

                // Mostrar resultados ordenados
                Console.WriteLine("Datos ordenados:");
                Console.WriteLine(string.Join(", ", data));

                // Preguntar al usuario si desea repetir con otro algoritmo
                Console.WriteLine("¿Desea probar otro algoritmo? (Sí/No)");
            } while (Console.ReadLine().Trim().ToUpper() == "SI");
        }

        static int[] ParseInput(string input)
        {
            // Convierte la entrada del usuario en un array de enteros
            return Array.ConvertAll(input.Split(','), int.Parse);
        }

        static dynamic GetSortingAlgorithm(int choice)
        {
            // Devuelve una instancia del algoritmo de ordenamiento seleccionado
            switch (choice)
            {
                case 1:
                    return new ShellSort();
                case 2:
                    return new SelectionSort();
                default:
                    throw new ArgumentException("Opción no válida");
            }
        }
    }
}
