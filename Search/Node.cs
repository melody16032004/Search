using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class Node<T>
    {
        private T value;
        private Node<T> next;


        public T Value
        {
            get { return value; }
            set { this.value = value; }
        }
        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }


        public Node()
        {
            Value = default;
            Next = null;
        }
        public Node(T value)
        {
            Value = value;
            Next = next;
        }

    }
}
