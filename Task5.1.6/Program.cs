namespace Task5_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetArrayFromConsole();   
            Console.ReadKey();
        }

        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            SortArray(result);

            Console.WriteLine("Отсортированный массив:");

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Элемент массива номер {0}", i + 1);
                Console.WriteLine(result[i]);
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
                        var temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }
            return arr; 
        }
    }
}