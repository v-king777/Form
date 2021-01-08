using System;

namespace Form
{
    class Program
    {
        static void Main(string[] args)
        {
            String MyName = "Vladimir";
            byte MyAge = 37;
            bool HavePet = false;
            double MyShoeSize = 40.5;

            Console.WriteLine($"My name is {MyName}");
            Console.WriteLine($"My age is {MyAge}");
            Console.WriteLine($"Do I have a pet? {HavePet}");
            Console.WriteLine($"My shoe size is {MyShoeSize}");

            Console.WriteLine("\nДля продолжения нажмите любую клавишу . . .");
            Console.ReadKey();
        }
    }
}
