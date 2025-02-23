using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Въвеждане на дължината и широчината
            Console.WriteLine("Въведете дължината на правоъгълника:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете широчината на правоъгълника:");
            int num1 = int.Parse(Console.ReadLine());

            // Извикване на метода за изчисление
            int area = zadcha(num, num1);

            // Отпечатване на резултата
            Console.WriteLine("Площта на правоъгълника е: " + area);
        }

        // Метод за изчисление на площ
        static int zadcha(int num, int num1)
        {
            return num * num1;
        }
    }
}



