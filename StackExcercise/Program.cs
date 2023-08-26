using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackExcercise
{
    class Program
    {

        public static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

        }
    }

    public class Stack
    {
        Stack<object> stack = new Stack<object>();
        public Stack()
        {

        }

        public void Push(object obj)
        {
            if (obj == null)
            {
                Console.WriteLine("Invalid Operation Exception");
            }
            else
            {
                stack.Push(obj);
            }
        }

        public object Pop()
        { return stack.Pop(); }

        public void Clear()
        {
            foreach (object obj in stack)
            {
                stack.Pop();
            }
        }
    }
}