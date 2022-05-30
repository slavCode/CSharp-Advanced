using System;
using System.Collections.Generic;
using System.Linq;

namespace E07_BalancedParentheses
{
    class BalancedParentheses
    {
        static void Main()
        {
            var input = Console.ReadLine();
            Stack<char> parentesis = new Stack<char>();

            char[] openParentheses = new char[] { '{', '(', '[' };
            for (int i = 0; i < input.Length; i++)
            {
                char bracket = input[i];
                if (openParentheses.Contains(bracket))
                {
                    parentesis.Push(input[i]);
                }
                else
                {
                    if (parentesis.Count < 1)
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                    switch (bracket)
                    {
                        case ')':
                            if (parentesis.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case '}':
                            if (parentesis.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ']':
                            if (parentesis.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                    }
                }
            }

            Console.WriteLine("YES");
        }
    }
}
