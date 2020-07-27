using System;
using System.Globalization;

namespace coordinatesConsole
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты через запятую:");
            string coordinates = Console.ReadLine();
            string[] x_y = coordinates.Split(',');
            decimal x = decimal.Parse(x_y[0], CultureInfo.InvariantCulture.NumberFormat);
            decimal y = decimal.Parse(x_y[1], CultureInfo.InvariantCulture.NumberFormat);
            Console.WriteLine($"X: {x} Y: {y}");
            Console.ReadKey();
        }
    }
}
