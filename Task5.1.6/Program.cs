namespace Task5_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var len = 5;
            ShowArray(GetArrayFromConsole(ref len), true);   
            Console.ReadKey();
        }

        static int[] GetArrayFromConsole(ref int num)
        {
            var result = new int[num];
            num = 6; 
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }

        static int[] SortArray(int[] arr)
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
        static void ShowArray(int[] arr, bool isSort = false)
        {
            var text = "Отсортированный массив:";

            if (isSort) SortArray(arr);
            else text = "массив: ";

            Console.WriteLine(text);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Элемент массива номер {0}", i + 1);
                Console.WriteLine(arr[i]);
            }
        }
    }
}