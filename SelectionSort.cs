using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAlgoritmosOrdenamiento
{
    internal class SelectionSort
    {
        public void Sort(int[] arr)
        {
            DisplayStepByStep(arr);
        }

        private void DisplayStepByStep(int[] arr)
        {
            Console.WriteLine("Proceso del Selection Sort:");

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Intercambiar el elemento mínimo con el primero no ordenado
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;

                Console.WriteLine(string.Join(", ", arr));
            }
        }
    }
}
