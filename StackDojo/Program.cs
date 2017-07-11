using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDojo
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericStack<int> stack = new GenericStack<int>(10);
            GenericStack<string> stack2 = new GenericStack<string>(10);

            Console.WriteLine(stack);
            stack.Push(422);
            Console.WriteLine(stack);
            stack.Push(62);
            Console.WriteLine(stack);
            stack.Push(7);
            Console.WriteLine(stack);
            stack.Push(46);
            Console.WriteLine(stack);
            stack.Push(2);
            Console.WriteLine(stack);
            stack.Push(4);
            Console.WriteLine(stack);
            stack.Push(966);
            Console.WriteLine(stack);
            stack.Push(47);
            Console.WriteLine(stack);
            stack.Push(765);
            Console.WriteLine(stack);
            stack.Push(568);
            Console.WriteLine(stack);
            stack.Push(20);
            Console.WriteLine(stack);
            stack.Pop();
            Console.WriteLine(stack);
            stack.Pop();
            Console.WriteLine(stack);
            Console.WriteLine(stack.Peek());
            // Console.WriteLine(stack2);

            Console.ReadKey();
        }
    }
}
