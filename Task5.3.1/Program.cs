namespace Task5_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свой возраст: ");
            var Age = int.Parse(Console.ReadLine());
            ChangeAge(ref Age);
            Console.WriteLine($"Возраст {Age}");
            Console.ReadKey();
        }
        static void ChangeAge(ref int age)
        {
            age += 5; 
        }
    }
}