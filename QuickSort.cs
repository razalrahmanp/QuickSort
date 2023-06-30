
using System;

public class QuickSort
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the size of the array: ");
        string sizeInput = Console.ReadLine();
        if (int.TryParse(sizeInput, out int size))
        {
            int[] array = new int[size];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                string elementInput = Console.ReadLine();
                if (int.TryParse(elementInput, out int element))
                {
                    array[i] = element;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--;
                }
            }

            Console.WriteLine("Original array: " + string.Join(", ", array));
            QuickSortAlgorithm(array, 0, array.Length - 1);
            Console.WriteLine("Sorted array: " + string.Join(", ", array));
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for the size of the array.");
        }
    }

    public static void QuickSortAlgorithm(int[] array, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = Partition(array, low, high);
            QuickSortAlgorithm(array, low, partitionIndex - 1);
            QuickSortAlgorithm(array, partitionIndex + 1, high);
        }
    }

    public static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, high);
        return i + 1;
    }

    public static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}