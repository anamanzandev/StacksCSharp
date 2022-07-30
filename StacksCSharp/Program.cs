using System.Collections;

namespace StacksCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UseMyStack();
            //UseCSharpStack();

            Console.ReadKey();
        }

        public static void UseMyStack()
        {
            var stack = new MyStack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.Write(stack.ToString());
            stack.Push(40);
            Console.Write(stack.ToString());

            int poppedElem = stack.Pop();
            Console.WriteLine($"Popped Element: {poppedElem}");
            Console.Write(stack.ToString());

            poppedElem = stack.Pop();
            Console.WriteLine($"Popped Element: {poppedElem}");
            Console.Write(stack.ToString());

            int peekedElem = stack.Peek();
            Console.WriteLine($"Peeked Element: {peekedElem}");

            poppedElem = stack.Pop();
            Console.WriteLine($"Popped Element: {poppedElem}");
            Console.Write(stack.ToString());

            poppedElem = stack.Pop();
            Console.WriteLine($"Popped Element: {poppedElem}");
            Console.Write(stack.ToString());

            // SHOULD THROW EXCEPTION
            //poppedElem = stack.Pop();
            //peekedElem = stack.Peek();
        }

        public static void UseCSharpStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            PrintStackValues(stack);
            stack.Push(40);
            PrintStackValues(stack);

            int poppedElem = stack.Pop();
            Console.WriteLine($"Popped Element: {poppedElem}");
            PrintStackValues(stack);

            poppedElem = stack.Pop();
            Console.WriteLine($"Popped Element: {poppedElem}");
            PrintStackValues(stack);

            int peekedElem = stack.Peek();
            Console.WriteLine($"Peeked Element: {peekedElem}");

            poppedElem = stack.Pop();
            Console.WriteLine($"Popped Element: {poppedElem}");
            PrintStackValues(stack);

            poppedElem = stack.Pop();
            Console.WriteLine($"Popped Element: {poppedElem}");
            PrintStackValues(stack);

            // SHOULD THROW EX
            //poppedElem = stack.Pop();
            //peekedElem = stack.Peek();
        }

        public static void PrintStackValues(IEnumerable myCollection)
        {
            Console.WriteLine("Start of Stack");
            foreach (Object obj in myCollection)
                Console.WriteLine("{0}", obj);
            Console.WriteLine("End of Stack");
            Console.WriteLine("");
        }
    }
}