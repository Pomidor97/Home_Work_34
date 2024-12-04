using System;
using System.Collections.Generic;
using ConsoleApp1HomeWork_34_task_3;

namespace ConsoleApp1HomeWork_34_task_3
{
    class Program
    {
        static void Main()
        {
            var stack = new ConsoleApp1HomeWork_34_task_3.Stack<string>();

            stack.Push("Kate");
            stack.Push("Sam");
            stack.Push("Alice");
            stack.Push("Tom");

            stack.Display(stack.GetStackState());
            stack.Push("Bob");

            Console.WriteLine("\nAfter adding 'Bob':");
            stack.Display(stack.GetStackState());

            Console.WriteLine($"\nPopped element: {stack.Pop()}");
            Console.WriteLine("\nAfter popping:");
            stack.Display(stack.GetStackState());
        }
    }
}
