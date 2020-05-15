using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.SetWindowSize(150, 30);

            var arr = new double[5000];
            var rng = new RandomNumberGenerator();
            for (int i = 0; i < 5000; i++)
            {
                var rnd = rng.Next(300);
                arr[rnd] += 1;
                Console.WriteLine($"{i} -> {rnd} ");
            }

            Console.WriteLine("");
            var frequency = new double[300];
            Console.WriteLine("Частота интервалов появления случайных чисел:");

            int count = 0;
            for (int i = 0; i < 300; i++)
            {
                frequency[i] = arr[i];
                count++;
                Console.WriteLine("Число {0} = {1}", i + 1, frequency[i]);
            }

            var stat = new double[300];

            double count1 = 0;
            for (int i = 0; i < 300; i++)
            {
                stat[i] = (frequency[i] / 5000);
                count1 += stat[i]; 
                Console.WriteLine("Число {0} = {1}", i + 1, stat[i]);
            }
            Console.WriteLine($"Частота интервалов появления случайных чисел: {count}");
            Console.WriteLine($"Статистическая вероятность случайных чисел: {(count1)}");

            
            double mathExpectedValue = 0;
            for (int i = 0; i < 300; i++)
            {
                mathExpectedValue += i * stat[i];
            }
            Console.WriteLine($"Математическое ожидание: {mathExpectedValue:F3}");

            double dispersion = 0;
            for (int i = 0; i < 300; i++)
            {
                dispersion += Math.Pow((i - mathExpectedValue), 2) * stat[i];
            }

            Console.WriteLine($"Дисперсия случайных величин: {dispersion:F3}");
            Console.WriteLine($"Среднее квадратическое отклонение случайных величин: {Math.Sqrt(dispersion):F3}");
            Console.ReadLine();
        }
    }

    class RandomNumberGenerator
    {
        private const long m = 2147483647; // aka 2^31-1
        private const long a = 48271;
        private const long c = 0;
        private long x;

        public RandomNumberGenerator()
        {
            Console.Write("x = ");
            x = long.Parse(Console.ReadLine());
        }

        public RandomNumberGenerator(long x)
        {
            this.x = x;
        }

        public long Next()
        {
            x = ((a * x) + c) % m;
            return x;
        }

        public long Next(long maxValue)
        {
            return Next() % maxValue;
        }
    }
}
