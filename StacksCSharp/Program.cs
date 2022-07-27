using System;

namespace StacksCSharp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = CreateStack();

            PrintAllElements(stack);
            stack.Push(40);
            PrintAllElements(stack);

            int poppedElem = stack.Pop();
            Console.WriteLine($"Popped Element: {poppedElem}");
            PrintAllElements(stack);

            poppedElem = stack.Pop();
            Console.WriteLine($"Popped Element: {poppedElem}");
            PrintAllElements(stack);

            int peekedElem = stack.Peek();
            Console.WriteLine($"Peeked Element: {peekedElem}");

            poppedElem = stack.Pop();
            Console.WriteLine($"Popped Element: {poppedElem}");
            PrintAllElements(stack);

            poppedElem = stack.Pop();
            Console.WriteLine($"Popped Element: {poppedElem}");
            PrintAllElements(stack);

            // SHOULD THROW EX
            //poppedElem = stack.Pop();
            //peekedElem = stack.Peek();

            Console.ReadKey();
        }

        public static MyStack CreateStack()
        {
            var stack = new MyStack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            return stack;
        }

        static void PrintAllElements(MyStack stack)
        {
            var pointer = stack.Top;
            Console.WriteLine("Start of Stack");
            while (pointer != null)
            {
                Console.WriteLine(pointer.Element);
                pointer = pointer.Next;
            }
            Console.WriteLine("End of Stack");
            Console.WriteLine("");
        }
    }
}