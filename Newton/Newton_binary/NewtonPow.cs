using System;

namespace Newton
{
    class NewtonPow
    {
        static void Main()
        {
            Console.WriteLine("Введите степень корня:");
            var rank = Console.ReadLine();
            double rankk = double.Parse(rank);
            Console.WriteLine("Введите число:");
            var numb = Console.ReadLine();
            double numbb = double.Parse(numb);
            Console.WriteLine($"Корень, вычисленный методом Ньютона: {SqrtN(rankk,numbb)}");
            Console.WriteLine($"Корень, вычисленный через Math.Pow: {Math.Pow(numbb,1/rankk)}");
        }

        static double Pow(double a, int pow)
        {
            double result = 1;
            for (int i = 0; i < pow; i++) result *= a;
            return result;
        }

        static double SqrtN(double n, double A, double eps = 0.0001)
        {
            var x0 = A / n;
            var x1 = (1 / n) * ((n - 1) * x0 + A / Pow(x0, (int)n - 1));

            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / n) * ((n - 1) * x0 + A / Pow(x0, (int)n - 1));
            }

            return x1;
        }
    }
}

