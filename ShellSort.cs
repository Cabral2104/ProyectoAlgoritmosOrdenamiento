using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAlgoritmosOrdenamiento
{
    public class ShellSort
    {
        public void Sort(int[] arr)
        {
            DisplayStepByStep(arr);
        }

        private void DisplayStepByStep(int[] arr)
        {
            Console.WriteLine("Proceso del Shell Sort:");

            for (int gap = arr.Length / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < arr.Length; i++)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }
                    arr[j] = temp;

                    Console.WriteLine(string.Join(", ", arr));
                }
            }
        }
    }
}
