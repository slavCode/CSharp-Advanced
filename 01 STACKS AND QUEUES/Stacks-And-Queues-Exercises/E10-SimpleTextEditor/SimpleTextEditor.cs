using System;
using System.Collections.Generic;
using System.Text;

namespace E10_SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main()
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            Queue<char> result = new Queue<char>();
            Stack<string> archive = new Stack<string>();

            for (int i = 0; i < numberOfOperations; i++)
            {
                var tokens = Console.ReadLine().Split();
                int command = int.Parse(tokens[0]);

                // Append text
                if (command == 1)
                {
                    string text = tokens[1];
                    for (int j = 0; j < text.Length; j++)
                    {
                        result.Enqueue(text[j]);
                    }
                    archive.Push(AddToArchive(result));
                }
                // Erease text
                else if (command == 2)
                {
                    int count = int.Parse(tokens[1]);
                    int textCount = result.Count;
                    for (int j = 0; j < textCount; j++)
                    {
                        if (result.Count - j <= count)
                        {
                            result.Dequeue();
                        }
                        else
                        {
                            result.Enqueue(result.Dequeue());
                        }
                    }
                    archive.Push(AddToArchive(result));
                }
                // Show element at index
                else if (command == 3)
                {
                    int index = int.Parse(tokens[1]);
                    int indexToEnqueue = result.Count - index;
                    for (int j = 1; j < index; j++)
                    {
                        result.Enqueue(result.Dequeue());
                    }

                    Console.WriteLine(result.Peek());

                    for (int j = 0; j <= indexToEnqueue; j++)
                    {
                        result.Enqueue(result.Dequeue());
                    }
                }
                // Undo
                else if (command == 4)
                {
                    if (archive.Count > 0)
                    {
                        archive.Pop();
                        if (archive.Count > 0)
                        {
                            var previous = archive.Peek();

                            result.Clear();
                            for (int j = 0; j < previous.Length; j++)
                            {
                                result.Enqueue(previous[j]);
                            }
                        }
                        else result.Clear();
                    }
                }
            }
        }

        static string AddToArchive(Queue<char> result)
        {
            var text = new StringBuilder();
            for (int i = 0; i < result.Count; i++)
            {
                char letter = result.Dequeue();
                text.Append(letter);
                result.Enqueue(letter);
            }
            return text.ToString();
        }
    }
}
