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

        BubbleSort.Sort(arr);

        Console.WriteLine("Отсортированный массив:");
        foreach (int element in arr)
            Console.Write(element + " ");
    }
}

public class BubbleSort
{
    public static void Sort(int[] array)
    {
        int n = array.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Обмен значений
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;

                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }
    }
}