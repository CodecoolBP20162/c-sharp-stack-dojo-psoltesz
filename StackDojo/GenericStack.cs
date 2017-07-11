using System;
using System.Collections.Generic;

namespace StackDojo
{
    public class GenericStack<T>
    {
        T[] stack;

        void Add(T input) { }

        public GenericStack(int n)
        {
            T[] stack = new T[n];
            this.stack = stack;
        }

        public void Push(T item)
        {
            for (int i = stack.Length - 2; i >= 0; i--)
            {
                stack[i + 1] = stack[i];
            }
            stack[0] = item;
        }

        public T Pop()
        {
            T result = stack[0];

            for (int i = 1; i < stack.Length - 1; i++)
            {
                stack[i + 1] = stack[i];
            }
            return result;
        }

        public string Peek()
        {
            return "Top item is: " + stack[0];
        }

        public override string ToString()
        {
            return String.Join(",", stack);
        }
    }
}
