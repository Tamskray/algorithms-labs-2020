using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePolishNotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            while (true)
            {
                Console.Write("Введите выражение: ");
                Console.WriteLine(PostfixNotationExpression.Calculate(Console.ReadLine()));
            }
        }
    }
}
