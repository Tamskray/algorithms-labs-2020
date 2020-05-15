using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab5
{
    class Program
    {
        static void SelectionSort(int[] arr)
        {
            int min, temp;
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
        }
        static void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }

        static DoubleLinkedList GetlistInsertionNext(int data)
        {
            DoubleLinkedList listInsertionNext = new DoubleLinkedList();

            listInsertionNext.Data = data;
            listInsertionNext.Previous = listInsertionNext.Next = null;
            return listInsertionNext;

        }
        static DoubleLinkedList InsertionSortList(DoubleLinkedList listInsertion, DoubleLinkedList listInsertionNext)
        {
            DoubleLinkedList current;
            if (listInsertion == null)
            {
                listInsertion = listInsertionNext;
            }
            else if (listInsertion.Data >= listInsertionNext.Data)
            {
                listInsertionNext.Next = listInsertion;
                listInsertionNext.Next.Previous = listInsertionNext;
                listInsertion = listInsertionNext;
            }

            else
            {
                current = listInsertion;
                while (current.Next != null && current.Next.Data < listInsertionNext.Data)
                {
                    current = current.Next;
                }
                listInsertionNext.Next = current.Next;

                if (current.Next != null)
                {
                    listInsertionNext.Next.Previous = listInsertionNext;
                }
                current.Next = listInsertionNext;
                listInsertionNext.Previous = current;
            }
            return listInsertion;
        }

        static void ShellsSort(int[] arr)
        {
            int step, i, j;
            int[] inc = new int[40];

            int p1 = 1, p2 = 1, p3 = 1;
            int s = -1;
            do
            {
                if (++s % 2 == 0)
                    inc[s] = 8 * p1 - 6 * p2 + 1;
                else
                {
                    inc[s] = 9 * p1 - 9 * p3 + 1;
                    p2 *= 2;
                    p3 *= 2;
                }
                p1 *= 2;
            } while (3 * inc[s] < inc.Length);

            s = s > 0 ? --s : 0;

            while (s >= 0)
            {
                step = inc[s--];

                for (i = step; i < arr.Length; i++)
                {
                    int temp = arr[i];

                    for (j = i - step; (j >= 0) && (arr[j] > temp); j -= step)
                        arr[j + step] = arr[j];
                    arr[j + step] = temp;
                }
            }
        }

        static void Main(string[] args)
        {
            Stopwatch checkTime;
            int[] arrSelection = new int[2000];
            Console.WriteLine("1.Сортировка выбором:");
            checkTime = Stopwatch.StartNew();
            for(int i =0; i< arrSelection.Length; i++)
            {
                Random rnd = new Random();
                arrSelection[i] = rnd.Next(-100, 100);
                SelectionSort(arrSelection);
            }
            checkTime.Stop();
            Console.WriteLine($"Время сортировки выбором -> {checkTime.ElapsedMilliseconds:F3} мс\n");

            int[] arrInsertion = new int[2000];
            Console.WriteLine("2.Сортировка вставками:");
            checkTime = Stopwatch.StartNew();
            for (int i = 0; i < arrInsertion.Length; i++)
            {
                Random rnd = new Random();
                arrInsertion[i] = rnd.Next(-100, 100);
                InsertionSort(arrInsertion);
            }
            checkTime.Stop();
            Console.WriteLine($"Время сортировки вставками -> {checkTime.ElapsedMilliseconds:F3} мс\n");

            Stopwatch checkTimeList;
            LinkedList<int> listInsertion = new LinkedList<int>();
            DoubleLinkedList list = null;
            Random rand = new Random();
            Console.WriteLine("3.Сортировка вставками списка:");
            checkTimeList = Stopwatch.StartNew();
            for (int i = 0; i < 2000; i++)
            {
                list = InsertionSortList(list, GetlistInsertionNext(rand.Next(-100, 100)));
            }
            checkTimeList.Stop();
            Console.WriteLine($"Время сортировки списка вставками -> {checkTimeList.ElapsedMilliseconds:F3} мс\n");

            int[] arrShell = new int[2000];
            Console.WriteLine("4.Сортировка Шелла:");
            checkTime = Stopwatch.StartNew();
            for (int i = 0; i < arrShell.Length; i++)
            {
                Random rnd = new Random();
                arrShell[i] = rnd.Next(-100, 100);
                ShellsSort(arrShell);
            }
            checkTime.Stop();
            Console.WriteLine($"Время сортировки -> {checkTime.ElapsedMilliseconds:F3} мс\n");
        }
    }
}