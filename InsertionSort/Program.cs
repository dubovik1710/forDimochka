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

        InsertionSort.Sort(arr);

        Console.WriteLine("Отсортированный массив:");
        foreach (int element in arr)
            Console.Write(element + " ");
    }
}

public class InsertionSort
{
    public static void Sort(int[] array)
    {
        int n = array.Length;

        for (int i = 1; i < n; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }

            array[j + 1] = key;
        }
    }
}