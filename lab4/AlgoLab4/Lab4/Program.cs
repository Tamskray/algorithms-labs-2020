using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static double Function(double x)
        {
            return 1 / Math.Log(x);
        }

        static double RightTriangle(double Result)
        {
            Console.WriteLine("Метод правых прямоугольников:");
            double a, b, n;
            Console.Write("Введите a = ");
            bool checkValueFora = false;
            do
            {
                if (double.TryParse(Console.ReadLine(), out a))
                {
                    checkValueFora = true;
                }
                else
                {
                    Console.WriteLine("Неверно введено!");
                }
            } while (checkValueFora == false);
            Console.Write("Введите b = ");
            bool checkValueForb = false;
            do
            {
                if (double.TryParse(Console.ReadLine(), out b))
                {
                    checkValueForb = true;
                }
                else
                {
                    Console.WriteLine("Неверно введено!");
                }
            } while (checkValueForb == false);
            Console.Write("Введите количество отрезков n = ");
            bool checkValueForn = false;
            do
            {
                if (double.TryParse(Console.ReadLine(), out n))
                {
                    checkValueForn = true;
                }
                else
                {
                    Console.WriteLine("Неверно введено!");
                }
            } while (checkValueForn == false);
            double step = (b - a) / n;
            double Summa = 0;
            for (int i = 1; i <= n; i++)
            {
                double x = a + i * step;
                Summa += Function(x);
            }
            Result = step * Summa;
            return Result;
        }

        static double LeftTriangle(double Result)
        {
            Console.WriteLine("Метод левых прямоугольников:");
            double a, b, n;
            Console.Write("Введите a = ");
            bool checkValueFora = false;
            do
            {
                if (double.TryParse(Console.ReadLine(), out a))
                {
                    checkValueFora = true;
                }
                else
                {
                    Console.WriteLine("Неверно введено!");
                }
            } while (checkValueFora == false);
            Console.Write("Введите b = ");
            bool checkValueForb = false;
            do
            {
                if (double.TryParse(Console.ReadLine(), out b))
                {
                    checkValueForb = true;
                }
                else
                {
                    Console.WriteLine("Неверно введено!");
                }
            } while (checkValueForb == false);
            Console.Write("Введите количество отрезков n = ");
            bool checkValueForn = false;
            do
            {
                if (double.TryParse(Console.ReadLine(), out n))
                {
                    checkValueForn = true;
                }
                else
                {
                    Console.WriteLine("Неверно введено!");
                }
            } while (checkValueForn == false);
            double step = (b - a) / n;
            double Summa = 0;
            for (int i = 0; i <= n-1; i++)
            {
                double x = a + i * step;
                Summa += Function(x);
            }
            Result = step * Summa;
            return Result;
        }

        static double Trapeze(double Result)
        {
            Console.WriteLine("Метод трапеции:");
            double a, b, n;
            Console.Write("Введите a = ");
            bool checkValueFora = false;
            do
            {
                if (double.TryParse(Console.ReadLine(), out a))
                {
                    checkValueFora = true;
                }
                else
                {
                    Console.WriteLine("Неверно введено!");
                }
            } while (checkValueFora == false);
            Console.Write("Введите b = ");
            bool checkValueForb = false;
            do
            {
                if (double.TryParse(Console.ReadLine(), out b))
                {
                    checkValueForb = true;
                }
                else
                {
                    Console.WriteLine("Неверно введено!");
                }
            } while (checkValueForb == false);
            Console.Write("Введите количество отрезков n = ");
            bool checkValueForn = false;
            do
            {
                if (double.TryParse(Console.ReadLine(), out n))
                {
                    checkValueForn = true;
                }
                else
                {
                    Console.WriteLine("Неверно введено!");
                }
            } while (checkValueForn == false);
            double step = (b - a) / n;
            double Summa = 0;
            for (int i = 1; i <= n-1; i++)
            {
                double x = a + i * step;
                Summa += 2*Function(x);
            }
            Result = (step / 2) * (Summa + Function(a) + Function(b));
            return Result;
        }

        static double SimpsonMethod(double Result)
        {
            Console.WriteLine("Метод трапеции:");
            double a, b, n;
            Console.Write("Введите a = ");
            bool checkValueFora = false;
            do
            {
                if (double.TryParse(Console.ReadLine(), out a))
                {
                    checkValueFora = true;
                }
                else
                {
                    Console.WriteLine("Неверно введено!");
                }
            } while (checkValueFora == false);
            Console.Write("Введите b = ");
            bool checkValueForb = false;
            do
            {
                if (double.TryParse(Console.ReadLine(), out b))
                {
                    checkValueForb = true;
                }
                else
                {
                    Console.WriteLine("Неверно введено!");
                }
            } while (checkValueForb == false);
            Console.Write("Введите количество отрезков n = ");
            bool checkValueForn = false;
            do
            {
                if (double.TryParse(Console.ReadLine(), out n))
                {
                    checkValueForn = true;
                }
                else
                {
                    Console.WriteLine("Неверно введено!");
                }
            } while (checkValueForn == false);

            double step = (b - a) / n;
            double Summa1 = 0;
            double Summa2 = 0;
            for (int i = 1; i <= n; i++)
            {
                double x1 = a + i * step;
                if(i <= n - 1)
                {
                    Summa1 += Function(x1);
                }
                double x2 = a + (i-1) * step;
                Summa2 += Function((x1 + x2)/2);
            }
            Result = (step / 3) * (0.5*Function(a) + Summa1 + 2*Summa2 + 0.5*Function(b));
            return Result;
        }

        static double MonteCarloMethod(double Result)
        {
            Console.WriteLine("Метод Монте-Карло:");
            double a, b, n;
            Console.Write("Введите a = ");
            bool checkValueFora = false;
            do
            {
                if (double.TryParse(Console.ReadLine(), out a))
                {
                    checkValueFora = true;
                }
                else
                {
                    Console.WriteLine("Неверно введено!");
                }
            } while (checkValueFora == false);
            Console.Write("Введите b = ");
            bool checkValueForb = false;
            do
            {
                if (double.TryParse(Console.ReadLine(), out b))
                {
                    checkValueForb = true;
                }
                else
                {
                    Console.WriteLine("Неверно введено!");
                }
            } while (checkValueForb == false);
            Console.Write("Введите количество отрезков n = ");
            bool checkValueForn = false;
            do
            {
                if (double.TryParse(Console.ReadLine(), out n))
                {
                    checkValueForn = true;
                }
                else
                {
                    Console.WriteLine("Неверно введено!");
                }
            } while (checkValueForn == false);
            double total = 0;
            double yMax = 0;
            double x;
            double funct;
            int i = 0;
            Random rnd = new Random();
            do
            {
                x = rnd.NextDouble() * ((b-a)+a);
                funct = Math.Abs(Function(x));
                if (yMax > funct)
                {
                    total += funct;
                    i++;
                }
                else
                {
                    yMax = funct * 2;
                    i = 0;
                }
            } while (i < n);
            Result = (b - a) * total / n;
            return Result;
        }

        static void Main(string[] args)
        {
            double res = 0;
            Console.WriteLine("1.Метод прямоугольников");
            Console.WriteLine("2.Метод трапеции");
            Console.WriteLine("3.Метод Симпсона");
            Console.WriteLine("4.Метод Монте-Карло");
            Console.WriteLine("5.Выход");
            int k;
            bool N = false;
            bool checkValue;
            do
            {
                do
                {
                    Console.WriteLine("Выберете пункт меню -> ");
                    if (int.TryParse(Console.ReadLine(), out k))
                        checkValue = false;
                    else
                        checkValue = true;
                } while (checkValue);
                switch (k)
                {
                    case 1:
                        Console.WriteLine("1.1.Метод правых прямоугольников");
                        Console.WriteLine($"{RightTriangle(res):F3}");
                        Console.WriteLine("1.2.Метод левых прямоугольников");
                        Console.WriteLine($"{LeftTriangle(res):F3}");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("2.Метод трапеции");
                        Console.WriteLine($"{Trapeze(res):F3}");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("3.Метод Симпсона");
                        Console.WriteLine($"{SimpsonMethod(res):F3}");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("4.Метод Монте-Карло");
                        Console.WriteLine($"{MonteCarloMethod(res):F3}");
                        Console.ReadKey();
                        break;
                    case 5:
                        N = true;
                        break;
                }
            } while (N == false);
        }
    }
}
