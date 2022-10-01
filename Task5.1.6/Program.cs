namespace Task5_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sortedarray = SortArray(GetArrayFromConsole());   
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

            //SortArray(result);

            //Console.WriteLine("Отсортированный массив:");

            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine("Элемент массива номер {0}", i + 1);
            //    Console.WriteLine(result[i]);
            //}
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
    }
}