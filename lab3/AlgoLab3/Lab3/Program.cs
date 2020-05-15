using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var doubleList = new DoubleLinkedList<string>();
            bool checkValue;
            int n;
            do
            {
                Console.WriteLine("Введите количество элементов -> ");
                if (int.TryParse(Console.ReadLine(), out n))
                    checkValue = false;
                else
                    checkValue = true;

            } while (checkValue);

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1} -> ");
                doubleList.Add(Console.ReadLine());
            }
            Console.WriteLine("1.Вивести список на дисплей");
            Console.WriteLine("2.Добавить новый елемент");
            Console.WriteLine("3.Добавить новый елемент в конец списка");
            Console.WriteLine("4.Удалить элемент");
            Console.WriteLine("5.Очистить список");
            Console.WriteLine("6.Реверсировать список");
            Console.WriteLine("7.Выход");
            int k;
            bool N = false;
            do
            { 
            var reverse = doubleList.Reverse();
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
                        Console.WriteLine("Список:");
                        foreach (var item in doubleList)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine(new string('=', 32));
                        Console.ReadKey();
                        break;
                    case 2:
                        bool checkValue1;
                        int n1;
                        do
                        {
                            Console.WriteLine("Введите количество элементов -> ");
                            if (int.TryParse(Console.ReadLine(), out n1))
                                checkValue1 = false;
                            else
                                checkValue1 = true;

                        } while (checkValue1);
                        for (int i = 0; i < n1; i++)
                        {
                            Console.Write($"{i + 1} -> ");
                            doubleList.Add(Console.ReadLine());
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Введите элемент ->");
                        doubleList.AddToEnd(Console.ReadLine());
                        Console.WriteLine(new string('=', 32));
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Введите элемент что бы удалить:");
                        doubleList.Delete(Console.ReadLine());
                        Console.WriteLine("Обновленный список");
                        foreach (var item in doubleList)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine(new string('=', 32));
                        Console.ReadKey();
                        break;
                    case 5:
                        doubleList.Clear();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("Реверсивный список");
                        Console.WriteLine();
                        foreach (var item in reverse)
                        {
                            Console.WriteLine(item);
                        }
                        Console.ReadKey();
                        break;
                    case 7:
                        N = true;
                        break;
                }
            }while (N == false) ;
        }
    }
}
