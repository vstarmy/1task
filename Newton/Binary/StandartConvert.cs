using System;

namespace Binary1
{
    class StandartConvert
    {
        static void Main()
        {
            Console.WriteLine("Введите десятичное число:");
            var n = Console.ReadLine();
            int i = Convert.ToInt32(n);
            var dec = Convert.ToString(i, 2);
            Console.WriteLine($"Двоичное представление данного числа: {dec}");
        }
    }
}
