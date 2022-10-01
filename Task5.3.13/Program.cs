using System;

namespace Task5_3_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] SortedDesc;
            int[] SortedAsc;

            var InputArray = GetArrayFromConsole();
            Console.WriteLine();
            SortArray(InputArray, out SortedDesc, out SortedAsc);

            ShowArray(SortedDesc);
            Console.WriteLine();
            ShowArray(SortedAsc);

            Console.ReadKey();
        }

        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }

        static void SortArray(int[] arr, out int[] sorteddesc, out int[] sortedasc)
        {               
            sorteddesc = new int[arr.Length];
            sortedasc = new int[arr.Length];
            Array.Copy(SortArrayDesc(arr), sorteddesc, arr.Length);
            Array.Copy(SortArrayAsc(arr), sortedasc, arr.Length);
        }

        static int[] SortArrayDesc(int[] arr)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length - j - 1; i++)
                {
                    if (arr[i + 1] < arr[i])
                    {
                        (arr[i + 1], arr[i]) = (arr[i], arr[i + 1]);
                    }
                }
            }
            return arr;
        }

        static int[] SortArrayAsc(int[] arr)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length - j - 1; i++)
                {
                    if (arr[i + 1] > arr[i])
                    {
                        (arr[i + 1], arr[i]) = (arr[i], arr[i + 1]);
                    }
                }
            }
            return arr;
        }

        static void ShowArray(int[] arr)
        {
            Console.WriteLine("Отсортированный массив:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Элемент массива номер {0}", i + 1);
                Console.WriteLine(arr[i]);
            }
        }
    }
}