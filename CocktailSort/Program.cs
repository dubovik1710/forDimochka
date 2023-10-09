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

        CocktailSort.Sort(arr);

        Console.WriteLine("Отсортированный массив:");
        foreach (int element in arr)
            Console.Write(element + " ");
    }
}

public class CocktailSort
{
    public static void Sort(int[] array)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            for (int i = left; i < right; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Swap(ref array[i], ref array[i + 1]);
                }
            }
            right--;

            for (int i = right; i > left; i--)
            {
                if (array[i - 1] > array[i])
                {
                    Swap(ref array[i - 1], ref array[i]);
                }
            }
            left++;
        }
    }

    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}