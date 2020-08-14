using System;

namespace TriangleTask
{
    class Program
    {
        class Triangle
        {
            public int M {get;set;}
            public int K {get; set;}
            public int N {get; set;}
            public bool IsTriangle
            {
                get
                {
                    if (M + K > N && M + N > K && K + N > M)
                    {
                        return true;
                    }
                    return false;
                }
            }
            public Triangle(int m_, int k_, int n_)
            {
                M = m_;
                K = k_;
                N = n_;
            }
            public int Perimetr()
            {
                return (M + K + N);
            }
            public double Square()
            {
                return Math.Sqrt(Halfper(this) * (Halfper(this) - M) * (Halfper(this) - N)
                    * (Halfper(this) - K));
            }
            static double Halfper(Triangle Obj)
            {
                return Obj.Perimetr() / 2.0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону М");
            var _M = Console.ReadLine();
            var M = int.Parse(_M);
            Console.WriteLine("Введите сторону К");
            var _K = Console.ReadLine();
            var K = int.Parse(_K);
            Console.WriteLine("Введите сторону N");
            var _N = Console.ReadLine();
            var N = int.Parse(_N);
            Triangle triangle = new Triangle(M, K, N);
            var value = triangle.IsTriangle;
            if (value == true)
            {
                Console.WriteLine($"Периметр треугольника:  { triangle.Perimetr()}");
                Console.WriteLine($"Площадь треугольника:  { triangle.Square()}");

            }
            else
            Console.WriteLine("Такой треугольник не существует!");

            Console.ReadKey();
        }
    }
}
