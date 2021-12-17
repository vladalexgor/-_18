using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_18
{
    /*Дана строка, содержащая скобки трёх видов(круглые, квадратные и фигурные) и любые другие символы. Проверить, корректно ли в ней расставлены скобки.
    Например, в строке ([]{ })[] скобки расставлены корректно, а в строке([]] — нет. Указание: задача решается однократным проходом по символам заданной строки слева направо;
    для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая, каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека
    (при этом скобка с вершины стека снимается); в конце прохода стек должен быть пуст.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку, содержащую скобки трех видов (круглые, квадратные и фигурные) и любые другие символы:");
            List<char> list = new List<char>(Console.ReadLine());
            Dictionary<char, char> brackets = new Dictionary<char, char>();
            brackets.Add('(', ')');
            brackets.Add('{', '}');
            brackets.Add('[', ']');
            Stack<char> stack = new Stack<char>();
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == '(')
                    {
                        stack.Push(brackets['(']);
                    }
                    else if (list[i] == '{')
                    {
                        stack.Push(brackets['{']);
                    }
                    else if (list[i] == '[')
                    {
                        stack.Push(brackets['[']);
                    }
                    if (list[i] == ')')
                    {
                        if (stack.Peek() == ')')
                        {
                            stack.Pop();
                        }
                    }
                    else if (list[i] == '}')
                    {
                        if (stack.Peek() == '}')
                        {
                            stack.Pop();
                        }
                    }
                    else if (list[i] == ']')
                    {
                        if (stack.Peek() == ']')
                        {
                            stack.Pop();
                        }
                    }
                }
                if (stack.Count == 0)
                {
                    Console.WriteLine("В введенном предложении скобки расставлены верно.");
                }
                else
                {
                    Console.WriteLine("В введенном предложении скобки расставлены неверно.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("В введенном предложении скобки расставлены неверно.");
            }
            Console.WriteLine("Для завершения программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
