using System.Security.Cryptography;

namespace Module5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetAnketa();
            Console.ReadKey();
        }

        static (string name, string surname, int age, bool ispet, int numofpets, string[] pets, int numofcolors, string[] favcolors) GetAnketa()
        {
            (string name, string surname, int age, bool ispet, int numofpets, string[] pets, int numofcolors, string[] favcolors) anketa;

            Console.Write("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            anketa.surname = Console.ReadLine();
            do
            {
                Console.Write("Укажите свой возраст: ");
                anketa.age = Convert.ToInt32(Console.ReadLine());
                if (!isCorrect(anketa.age))
                    Console.WriteLine("Вы ввели неправильный возраст!!!");
            } while (!isCorrect(anketa.age));

            Console.Write("У вас есть питомец? (да/нет) ");
            switch (Console.ReadLine())
            {
                case "Да":
                case "да":
                    anketa.ispet = true;
                    break;
                default:
                    anketa.ispet = false;
                    break;
            }
            if (anketa.ispet)
            {
                do
                {
                    Console.Write("Сколько у вас питомцев? ");
                    anketa.numofpets = Convert.ToInt32(Console.ReadLine());
                    if (!isCorrect(anketa.numofpets))
                        Console.WriteLine("Вы ввели неправильное количества питомцев!!!");
                } while (!isCorrect(anketa.numofpets));
                anketa.pets = GetPets(anketa.numofpets);
            }
            else
            {
                anketa.pets = new string[0];
                anketa.numofpets = 0;
            }

            Console.Write("У вас есть любимые цвета? (да/нет) ");
            switch (Console.ReadLine())
            {
                case "Да":
                case "да":
                    do
                    {
                        Console.Write("Сколько у вас любымых цветов? ");
                        anketa.numofcolors = Convert.ToInt32(Console.ReadLine());
                        if (!isCorrect(anketa.numofcolors))
                            Console.WriteLine("Вы ввели не правильное число любимых цветов!!!");
                    } while (!isCorrect(anketa.numofcolors));
                    anketa.favcolors = GetColors(anketa.numofcolors);
                    break;
                default:
                    anketa.favcolors = new string[0];
                    anketa.numofcolors = 0;
                    break;
            }

            return anketa;
        }

        private static string[] GetColors(int numofcolors)
        {
            var colors = new string[numofcolors];

            for (int i = 0; i < numofcolors; i++)
            {
                Console.Write($"какой ваш {i + 1} любимый цвет? ");
                colors[i] = Console.ReadLine();
            }
            return colors;
        }

        static string[] GetPets(int numofpets)
        {
            var pets = new string[numofpets];

            for (int i = 0; i < numofpets; i++)
            {
                Console.Write($"как зовут вашего {i + 1} питомца? ");
                pets[i] = Console.ReadLine();
            }
            return pets;
        }
        static bool isCorrect(int number)
        {
            return (number > 0 && number < 200);
        }
    }
}