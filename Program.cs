using System;

class Program
{
    static double SinDegrees(double degrees) => Math.Sin(degrees * Math.PI / 180.0);

    static void Main(string[] args)
    {
        Console.Write("Введіть початкове значення аргументу (градуси): ");
        double a_start = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть кінцеве значення аргументу (градуси): ");
        double a_end = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть крок зміни аргументу (градуси): ");
        double step = Convert.ToDouble(Console.ReadLine());

        // Перевірка на правильність введених значень
        if (a_start < 0  a_end > 360  step <= 0)
        {
            Console.WriteLine("Помилка");
            return;
        }

        Console.WriteLine("{0,10} | {1,10}", "Кут (градуси)", "sin(a)");
        Console.WriteLine(new string('-', 25));

        double a = a_start;
        while (a <= a_end)
        {
            Console.WriteLine("{0,10:F3} | {1,10:F3}", a, SinDegrees(a));
            a += step;
        }
    }
}