namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string[] Dishes) User;
            User.Dishes = new string[5];

            Console.Write("Введите имя: ");
            User.Name = Console.ReadLine();

            Console.WriteLine("Укажите пять своих любимых блюд");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i + 1} блюдо: ");
                User.Dishes[i] = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}