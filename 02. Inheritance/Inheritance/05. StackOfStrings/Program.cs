﻿using System;

namespace _05._StackOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();
            stack.Push("Pesho");
            stack.Push("Ivan");
            stack.Push("Gosho");

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.IsEmpty());
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Console.WriteLine(stack.IsEmpty());
        }
    }
}
