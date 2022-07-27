namespace StacksCSharp
{
    public class MyStack 
    {
        public Node Top { get; private set; }
        public int Length { get; private set; }

        public MyStack()
        {
            Top = null;
            Length = 0;
        }

        // Inserts an element at the top of the stack
        public void Push(int element) 
        {
            var newTop = new Node(element);
            newTop.Next = Top;
            Top = newTop;
            Length++;
        }

        // Removes the element at the top of the stack
        public int Pop() 
        {
            if (Top == null)
            {
                throw new Exception("There are no elements to be popped from the stack.");
            }

            int oldTop = Top.Element;
            Top = Top.Next;
            Length--;
            return oldTop;
        }

        // Returns the element at the top of the stack without removing it
        public int Peek()
        {
            if (Top == null)
            {
                throw new Exception("There are no elements in the stack.");
            }
            return Top.Element;
        }
    }
}
