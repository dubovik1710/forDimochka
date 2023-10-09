using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace Sort
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int[] array_1000 { get; private set; }
        public int[] array_10000 { get; private set; }
        public int[] array_100000 { get; private set; }

        public bool isArrayOf1000=false;
        public bool isArrayOf10000 = false;
        public bool isArrayOf100000 = false;

        
        Stopwatch sw = new Stopwatch();

        private string time;

        public MainWindow()
        {
            InitializeComponent();

        }

        static int[] GenerateArray(int size) //генерация массива с заданной размерностью
        {
            Random random = new Random();
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(-100, 100 + 1);
            }

            return arr;
        }

        public int[] GenerateArray_1000() //генерация массива с заданной размерностью
        {
            

            Random random = new Random();
            int[] arr = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                arr[i] = random.Next(-100, 100 + 1);
            }

            return arr;
            
            
            
            
        }

        

        public int[] GenerateArray_10000() //генерация массива с заданной размерностью
        {
            Random random = new Random();
            int[] arr = new int[10000];

            for (int i = 0; i < 10000; i++)
            {
                arr[i] = random.Next(-100, 100 + 1);
            }

            return arr;
            
        }

        public int[] GenerateArray_100000() //генерация массива с заданной размерностью
        {
            Random random = new Random();
            int[] arr = new int[100000];

            for (int i = 0; i < 100000; i++)
            {
                arr[i] = random.Next(-100, 100 + 1);
            }

            return arr;
            
        }

        public void generate_1_000_Click(object sender, RoutedEventArgs e)
        {
            

            array_1000 = GenerateArray_1000();

            string[] result = array_1000.Select(i => i.ToString()).ToArray();
            arrayBeforeSorting.Document.Blocks.Clear();
            //arrayAfterSorting.AppendText(string.Join(", ", result));
            arrayBeforeSorting.AppendText(string.Join(", ", result));
            isArrayOf1000 = true;
            isArrayOf10000 = false;
            isArrayOf100000 = false;

            

        }
        private void generate_10_000_Click(object sender, RoutedEventArgs e)
        {
            array_10000 = GenerateArray_10000();
            string[] result = array_10000.Select(i => i.ToString()).ToArray();
            arrayBeforeSorting.Document.Blocks.Clear();
            arrayBeforeSorting.AppendText(string.Join(", ", result));
            isArrayOf1000 = false;
            isArrayOf10000 = true;
            isArrayOf100000 = false;

        }

        private void generate_100_000_Click(object sender, RoutedEventArgs e)
        {
            array_100000 = GenerateArray_100000();
            string[] result = array_100000.Select(i => i.ToString()).ToArray();
            arrayBeforeSorting.Document.Blocks.Clear();
            arrayBeforeSorting.AppendText(string.Join(", ", result));
            isArrayOf1000 = false;
            isArrayOf10000 = false;
            isArrayOf100000 = true;
        }

        

        // Алгоритм сортировки пузырьком
        static int[] BubbleSort(int[] arr)
        {
            
           
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Обмен элементов
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;

        }

        private void BubbleSortButton_Click(object sender, RoutedEventArgs e)
        {
            sw.Start();

            int[] res;

            if (isArrayOf1000 == true)
            {
                res = BubbleSort(array_1000);
            }
            else if (isArrayOf10000 == true)
            {
                res = BubbleSort(array_10000);
            }
            else
            {
                res = BubbleSort(array_100000);
            }

            sw.Stop();
            string time = sw.ElapsedMilliseconds.ToString();
            AlgorithmExecutionTime.Text = time;

            sw.Reset();


            string[] result = res.Select(i => i.ToString()).ToArray();
            arrayAfterSorting.Document.Blocks.Clear();
            arrayAfterSorting.AppendText(string.Join(", ", result));
        }

        // Алгоритм сортировки выбором
        static int[] SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Обмен элементов
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }

        private void SelectionSort_Click(object sender, RoutedEventArgs e)
        {
            sw.Start();

            int[] res;

            if (isArrayOf1000 == true)
            {
                res = SelectionSort(array_1000);
            }
            else if (isArrayOf10000 == true)
            {
                res = SelectionSort(array_10000);
            }
            else
            {
                res = SelectionSort(array_100000);
            }

            sw.Stop();
            string time = sw.ElapsedMilliseconds.ToString();
            AlgorithmExecutionTime.Text = time;

            sw.Reset();

            string[] result = res.Select(i => i.ToString()).ToArray();
            arrayAfterSorting.Document.Blocks.Clear();
            arrayAfterSorting.AppendText(string.Join(", ", result));
        }

        // Алгоритм сортировки слиянием
        static int[] MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(arr, left, middle);
                MergeSort(arr, middle + 1, right);

                Merge(arr, left, middle, right);
            }
            return arr;
        }

        static void Merge(int[] arr, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
            {
                leftArray[i] = arr[left + i];
            }

            for (int j = 0; j < n2; j++)
            {
                rightArray[j] = arr[middle + 1 + j];
            }

            int k = left;
            int p = 0;
            int q = 0;

            while (p < n1 && q < n2)
            {
                if (leftArray[p] <= rightArray[q])
                {
                    arr[k] = leftArray[p];
                    p++;
                }
                else
                {
                    arr[k] = rightArray[q];
                    q++;
                }
                k++;
            }

            while (p < n1)
            {
                arr[k] = leftArray[p];
                p++;
                k++;
            }

            while (q < n2)
            {
                arr[k] = rightArray[q];
                q++;
                k++;
            }
        }


        private void MergeSort_Click(object sender, RoutedEventArgs e)
        {
            sw.Start();

            int[] res;

            if (isArrayOf1000 == true)
            {
                res = MergeSort(array_1000, 0, array_1000.Length-1);
            }
            else if (isArrayOf10000 == true)
            {
                res = MergeSort(array_10000, 0, array_10000.Length - 1);
            }
            else
            {
                res = MergeSort(array_100000, 0, array_100000.Length - 1);
            }

            sw.Stop();
            string time = sw.ElapsedMilliseconds.ToString();
            AlgorithmExecutionTime.Text = time;

            sw.Reset();

            string[] result = res.Select(i => i.ToString()).ToArray();
            arrayAfterSorting.Document.Blocks.Clear();
            arrayAfterSorting.AppendText(string.Join(", ", result));
        }

        // Алгоритм шейкерной сортировки
        static int[] ShakerSort(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            bool swapped = false;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        // Обмен элементов
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }

                swapped = false;
                right--;

                for (int i = right; i > left; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        // Обмен элементов
                        int temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                        swapped = true;
                    }
                }

                left++;
            }

            return arr;
        }

        private void ShakerSort_Click(object sender, RoutedEventArgs e)
        {
            sw.Start();

            int[] res;

            if (isArrayOf1000 == true)
            {
                res = ShakerSort(array_1000);
            }
            else if (isArrayOf10000 == true)
            {
                res = ShakerSort(array_10000);
            }
            else
            {
                res = ShakerSort(array_100000);
            }

            sw.Stop();
            string time = sw.ElapsedMilliseconds.ToString();
            AlgorithmExecutionTime.Text = time;

            sw.Reset();

            string[] result = res.Select(i => i.ToString()).ToArray();
            arrayAfterSorting.Document.Blocks.Clear();
            arrayAfterSorting.AppendText(string.Join(", ", result));
        }
    

        // Алгоритм быстрой сортировки
        static int[] QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
            return arr;
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;

                    // Обмен элементов
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // Обмен элементов
            int temp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp2;

            return i + 1;
        }

        private void QuickSort_Click(object sender, RoutedEventArgs e)
        {
            sw.Start();
            
            int[] res;

            if (isArrayOf1000 == true)
            {
                res = QuickSort(array_1000, 0, array_1000.Length - 1);
            }
            else if (isArrayOf10000 == true)
            {
                res = QuickSort(array_10000, 0, array_10000.Length - 1);
            }
            else
            {
                res = QuickSort(array_100000, 0, array_100000.Length - 1);
            }

            sw.Stop();
            string time = sw.ElapsedMilliseconds.ToString();
            AlgorithmExecutionTime.Text = time;

            sw.Reset();

            string[] result = res.Select(i => i.ToString()).ToArray();
            arrayAfterSorting.Document.Blocks.Clear();
            arrayAfterSorting.AppendText(string.Join(", ", result));

        }
    

        // Алгоритм сортировки вставками
        static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }
            return arr;
        }


        private void InsertionSort_Click(object sender, RoutedEventArgs e)
        {
            sw.Start();

            int[] res;

            if (isArrayOf1000 == true)
            {
                res = InsertionSort(array_1000);
            }
            else if (isArrayOf10000 == true)
            {
                res = InsertionSort(array_10000);
            }
            else
            {
                res = InsertionSort(array_100000);
            }

            sw.Stop();
            string time = sw.ElapsedMilliseconds.ToString();
            AlgorithmExecutionTime.Text = time;

            sw.Reset();

            string[] result = res.Select(i => i.ToString()).ToArray();
            arrayAfterSorting.Document.Blocks.Clear();
            arrayAfterSorting.AppendText(string.Join(", ", result));
        }

        

        
    }
}
