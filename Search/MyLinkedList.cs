using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class MyLinkedList<T>
    {
        private Node<T> head = null;
        private Node<T> tail = null;
        private int count = 0;

        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public MyLinkedList(T[] obj)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                AddLast(obj[i]);
            }
        }

        public bool Empty()
        {
            return head == null;
        }

        public void AddFirst(Node<T> newNode)
        {
            if (Empty())
            {
                head = tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
                count++;
            }
        }
        public void AddFirst(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (Empty())
            {
                head = tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
                count++;
            }
        }

        public void AddLast(Node<T> newNode)
        {
            if (Empty())
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
                count++;
            }
        }
        public void AddLast(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (Empty())
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
                count++;
            }
        }

        public Node<T> FindX(Node<T> x)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Value.Equals(x.Value))
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }
        public Node<T> FindX(T x)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Value.Equals(x))
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public void InsertAfter(Node<T> p, Node<T> newNode)
        {
            if (p == tail)
            {
                AddLast(newNode);
            }
            else
            {
                newNode.Next = p.Next;
                p.Next = newNode;
                count++;
            }
        }
        public void InsertAfter(T x, T y)
        {
            Node<T> p = new Node<T>(x);
            Node<T> newNode = new Node<T>(y);

            if (p == tail)
            {
                AddLast(newNode);
            }
            else
            {
                newNode.Next = p.Next;
                p.Next = newNode;
                count++;
            }
        }

        public void InsertBefore(Node<T> p, Node<T> newNode)
        {
            InsertAfter(p, newNode);
            SwapNode(p, newNode);
        }
        public void InsertBefore(T x, T y)
        {
            Node<T> p = new Node<T>(x);
            Node<T> newNode = new Node<T>(y);

            InsertAfter(p, newNode);
            SwapNode(p, newNode);
        }

        public void SwapNode(Node<T> p, Node<T> newNode)
        {
            T tmp = p.Value;
            p.Value = newNode.Value;
            newNode.Value = tmp;
        }


        public int Count()
        {
            return count;
        }

        public void Display()
        {
            Node<T> p = head;
            while (p != null)
            {
                if (p.Next == null)
                {
                    Console.Write(p.Value + " -> Null \n\n");
                }
                else
                {
                    Console.Write(p.Value + " -> ");
                }
                p = p.Next;
            }
        }
    }
}
