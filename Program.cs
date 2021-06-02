using System;
using System.Collections.Generic;
using System.Linq;

namespace SortProject
{
    class SortingProgram
    {
        //using selection sort algorithm
        //Put Values in the debug menu like
        //50 70 50 80 89 25 78 58 83 73
        public static void Main(string[] args)
        {
            var inputsArray = args != null && args.Length != 0 ? args.Select(int.Parse).ToList() : new List<int> { 50, 70, 50, 80, 89, 25, 78, 58, 83, 73 };
            var combinedInputs = string.Join(", ", inputsArray);
            Console.WriteLine($"Main array: \n {combinedInputs} \n");
            Sort(inputsArray);
            var combinedOutputs = string.Join(", ", inputsArray);
            Console.WriteLine($"\n \n Sorted array: \n {combinedOutputs} \n");
        }

        private static void Sort(List<int> inputs)
        {
            int n = inputs.Count();
            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (inputs[j] < inputs[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Swap the founded minimum element with the first element
                Swap(inputs, i, minIndex);
                //Print step sorted array
                var stepArray = string.Join(", ", inputs);
                Console.Write($"step {i+1}: \n {stepArray} \n");
            }
        }
        private static void Swap(List<int> inputs, int currentIndex, int minIndex)
        {
            int temp = inputs[minIndex];
            inputs[minIndex] = inputs[currentIndex];
            inputs[currentIndex] = temp;
        }
    }
}
