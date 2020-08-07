using System;

namespace Binary2
{
    class Bicycle
    {
        static void Main()
        {
            Console.WriteLine("Введите десятичное число: ");
            var d = Console.ReadLine();
            int dec = Convert.ToInt32(d);
            int i = 0;

            int[] b = new int[10];
            int a = 0;

            while (dec >= 1)
            {
                a = dec % 2;
                b[i] = a;
                i++;
                dec /= 2;
                Console.Write(a);
            }

            Console.ReadKey();
        }
    }
}
