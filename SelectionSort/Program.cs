using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите количество элементов в массиве: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Введите элемент {0}: ", i + 1);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        SelectionSort.Sort(arr);

        Console.WriteLine("Отсортированный массив:");
        foreach (int element in arr)
            Console.Write(element + " ");
    }
}

public class SelectionSort
{
    public static void Sort(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                    minIndex = j;
            }

            // Обмен значений
            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }
}