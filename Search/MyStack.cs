using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class MyStack<T>
    {
        private Node<T> top;
        private int count = 0;

        public MyStack()
        {

        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.Next = top;
                top = newNode;
            }
            count++;
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T data = top.Value;
            top = top.Next;
            count--;
            return data;
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return top.Value;
        }
        public int Count()
        {
            return count;
        }
        public void Input()
        {

        }
        public void Display()
        {
            Node<T> p = top;
            while (p != null)
            {
                Console.Write(p.Value + " ");
                p = p.Next;
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
