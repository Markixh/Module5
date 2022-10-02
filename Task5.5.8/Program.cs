namespace Task5_5_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PowerUp(2, 3));
        }
        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0) return 1;
            else return N * PowerUp(N, --pow);
        }
    }
}