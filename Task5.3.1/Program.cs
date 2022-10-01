namespace Task5_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свой возраст: ");
            var Age = int.Parse(Console.ReadLine());
            ChangeAge(Age);
            Console.WriteLine($"Возраст {Age}");
            Console.ReadKey();
        }
        static void ChangeAge(int age)
        {
            age += 5; 
        }
    }
}