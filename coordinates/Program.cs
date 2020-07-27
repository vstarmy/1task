
using System;
using System.IO;
using System.Globalization;

/// <summary>
/// задание с файлом
/// </summary>

namespace coordinates
{
    class Program2
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///создание файла и его закрытие
            ///<summary>
            string file = "file.txt";
            File.Create(file).Dispose();

            ///<summary>
            ///запись текста в файл
            ///<summary>
            File.WriteAllText(file, "23.8976,12.3218" + "\n" +
                "25.76,11.9463" + "\n" +
                "24.8293,12.2" + "\n");

            ///<summary>
            ///считывание каждой строки и распределение по координатам, затем перевод из строки в decimal
            ///<summary>
            StreamReader reader = new StreamReader("file.txt");
            while (!reader.EndOfStream)
            {
                string str = reader.ReadLine();
                Console.WriteLine(str);
                string x_s = str.Substring(0, str.IndexOf(','));
                decimal x = decimal.Parse(x_s, CultureInfo.InvariantCulture.NumberFormat);

                string y_s = str.Substring(str.IndexOf(',') + 1);
                decimal y = decimal.Parse(y_s, CultureInfo.InvariantCulture.NumberFormat);
                Console.WriteLine($"X: {x} Y: {y}");
            }
            Console.ReadKey();
        }
    }

}
