using System;

namespace Form
{
    class Program
    {
        static void Main(string[] args)
        {
            // Имя и возраст
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age;
            bool errAge = byte.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Your name is {0} and age is {1}\n", name, age);

            // Дата рождения и любимый день
            Console.Write("What is your birthdate? ");
            var birthdate = Console.ReadLine();
            Console.Write("What is your favorite day of week? ");
            DayOfWeek day;
            bool errDay = DayOfWeek.TryParse(Console.ReadLine(), out day);
            Console.WriteLine("Your birthdate is {0}", birthdate);
            Console.WriteLine("Your favorite day is {0}", day);
            
            // Выход
            Console.WriteLine("\nДля продолжения нажмите любую клавишу . . .");
            Console.ReadKey();
        }
    }
}
