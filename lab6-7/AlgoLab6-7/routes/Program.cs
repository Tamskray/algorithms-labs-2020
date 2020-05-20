using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace routes
{
    class Program
    {
        static bool[] check = new bool[19];
        static int[,] distance = new int[19, 19];
        static string[] city = new string[19]
        {
            "Киев", "Житомир", "Новоград-Волынский", "Ровно", "Луцк", "Бердичев", "Винница", "Хмельницкий", "Тернополь", "Шепетовка", "Белая церковь", "Умань", "Черкассы", "Кременчуг", "Полтава", "Харьков", "Прилуки", "Сумы", "Миргород"
        };
        public static void PossibleRoutes(int count, string prev, int weight)
        {
            string ways;
            if (count == 0)
            {
                ways = city[count];
            }
            else
            {
                ways = prev + " - " + $"({weight})" + city[count];
            }
            Console.WriteLine(ways);
            distance[0, 1] = 135;
            distance[0, 10] = 78;
            distance[0, 16] = 128;
            distance[1, 2] = 80;
            distance[1, 5] = 38;
            distance[1, 9] = 115;
            distance[2, 3] = 100;
            distance[3, 4] = 68;
            distance[5, 6] = 73;
            distance[6, 7] = 110;
            distance[7, 8] = 104;
            distance[10, 11] = 146;
            distance[10, 13] = 115;
            distance[10, 14] = 181;
            distance[11, 12] = 105;
            distance[14, 15] = 130;
            distance[16, 17] = 175;
            distance[16, 18] = 109;
            for (int i = 0; i < 19; i++)
            {
                if (check[i] == false && distance[count, i] != 0)
                {
                    PossibleRoutes(i, ways, weight = distance[count, i]);
                }
            }
        }

        static void Main(string[] args)
        {
            int count = 0;
            PossibleRoutes(count, "", 0);
        }
    }
}
