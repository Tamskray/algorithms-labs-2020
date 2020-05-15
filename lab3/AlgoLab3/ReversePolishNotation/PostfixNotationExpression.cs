using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePolishNotation
{
    public class PostfixNotationExpression
    {
        static public double Calculate(string value)
        {
            string outputValue = Expression(value);
            double Result = Counting(outputValue);
            return Result;
        }

        static private string Expression(string value)
        {
            string outputValue = string.Empty;
            Stack<char> valueStack = new Stack<char>();
            for (int i = 0; i < value.Length; i++)
            {
                if (Delimeter(value[i]))
                    continue;
                if (Char.IsDigit(value[i]))
                {
                    while (!Delimeter(value[i]) && !Operator(value[i]))
                    {
                        outputValue += value[i];
                        i++;

                        if (i == value.Length) break;
                    }

                    outputValue += " ";
                    i--;
                }

                if (Operator(value[i]))
                {
                    if (value[i] == '(')
                        valueStack.Push(value[i]);
                    else if (value[i] == ')')
                    {
                        char s = valueStack.Pop();

                        while (s != '(')
                        {
                            outputValue += s.ToString() + ' ';
                            s = valueStack.Pop();
                        }
                    }
                    else
                    {
                        if (valueStack.Count > 0)
                        {
                            if (Priority(value[i]) <= Priority(valueStack.Peek()))
                            {
                                outputValue += valueStack.Pop().ToString() + " ";
                            }
                        }
                        valueStack.Push(char.Parse(value[i].ToString()));

                    }
                }
            }
            while (valueStack.Count > 0)
            {
                outputValue += valueStack.Pop() + " ";
            }
            return outputValue;
        }

        static private double Counting(string value)
        {
            double result = 0;
            Stack<double> temp = new Stack<double>();

            for (int i = 0; i < value.Length; i++)
            {
                if (Char.IsDigit(value[i]))
                {
                    string a = string.Empty;

                    while (!Delimeter(value[i]) && !Operator(value[i]))
                    {
                        a += value[i];
                        i++;
                        if (i == value.Length) break;
                    }
                    temp.Push(double.Parse(a));
                    i--;
                }
                else if (Operator(value[i]))
                {
                    double a = temp.Pop();
                    double b = temp.Pop();

                    switch (value[i])
                    {
                        case '+': result = b + a; 
                            break;
                        case '-': result = b - a; 
                            break;
                        case '*': result = b * a; 
                            break;
                        case '/': result = b / a;
                            break;
                        case '^': result = double.Parse(Math.Pow(double.Parse(b.ToString()), double.Parse(a.ToString())).ToString()); 
                            break;
                    }
                    temp.Push(result);
                }
            }
            return temp.Peek();
        }

        static private bool Delimeter(char symbol)
        {
            if ((" =".IndexOf(symbol) != -1))
                return true;
            return false;
        }

        static private bool Operator(char symbol)
        {
            if (("+-/*^()".IndexOf(symbol) != -1))
                return true;
            return false;
        }

        static private byte Priority(char operation)
        {
            switch (operation)
            {
                case '(': return 0;
                case ')': return 1;
                case '+': return 2;
                case '-': return 3;
                case '*': return 4;
                case '/': return 4;
                case '^': return 5;
                default: return 6;
            }
        }
    }
}