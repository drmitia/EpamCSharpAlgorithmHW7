using System.Diagnostics;

namespace EpamHW7__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 10, 4, 3, 9, 8, 6, 5, 2, 1 };
            int[] array2 = { 7, 10, 4, 3, 9, 8, 6, 5, 2, 1 };
            BubbleSort(array);
            SelectionSort(array2);
        }
        static void BubbleSort(int[] array)
        {
            int k = 0;
            int p = 0;
            int length = array.Length;
            for (int i = 1; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    p++;
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        k++;
                    }
                }
            }
            Console.WriteLine($"Бульбашкове сортування робить {p} порівнянь та {k} обмінів");
        }
        static void SelectionSort(int[] array)
        { //Сортування простим вибором
            int d = 0;
            int a = 0;
            int len = array.Length;
            for (int i = 0; i < len - 1; i++)
            {   
                int nmin = i;
                for (int j = i + 1; j < len; j++)
                {
                    a++;
                    if (array[j] < array[nmin])
                    {
                        nmin = j;
                        d++;
                    }
                }
                int temp = array[i];
                array[i] = array[nmin];
                array[nmin] = temp;
            }
            Console.WriteLine($"Сортування простим вибором робить {a} порівнянь та {d} обмінів");
        }
    }
}