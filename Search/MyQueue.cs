using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class MyQueue<T>
    {
        private T[] qArray;
        private int qMax;
        private int qFront;
        private int qRear;
        private int count;

        public MyQueue()
        {
            qArray = new T[5];
            qMax = qArray.Length;
            qFront = qRear = -1;
        }
        public MyQueue(int MaxItem)
        {
            qArray = new T[MaxItem];
            qMax = MaxItem;
            qFront = qRear = -1;
        }
        public bool IsEmpty()
        {
            return qFront == -1;
        }
        public bool IsFull()
        {
            return (qRear + 1) % qMax == qFront;
        }

        public void EnQueue(T newitem)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full..!");
            }
            else
            {
                if (IsEmpty())
                {
                    qFront = qRear = 0;
                }
                else
                {
                    qRear = (qRear + 1) % qMax;
                }
                qArray[qRear] = newitem;
                count++;
            }
        }
        public void DeQueue(out T itemout)
        {
            itemout = default;
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty..!");
            }
            else
            {
                itemout = qArray[qFront];
                if (qFront == qRear)
                {
                    qFront = qRear = -1;
                }
                else
                {
                    qFront = (qFront + 1) % qMax;
                }
                count--;
            }
        }
        public void Top(out T item)
        {
            item = default;
            if (IsEmpty())
            {
                //return false;
                Console.WriteLine("Queue is empty..!");
            }
            item = qArray[qFront];
            Console.WriteLine("Top:  " + item);
            //return true;
        }
        public void Last(out T item)
        {
            item = default;
            if (IsEmpty())
            {
                //return false;
                Console.WriteLine("Queue is empty..!");
            }
            item = qArray[qRear];
            Console.WriteLine("Last:  " + item);
            //return true;
        }
        public int Count()
        {
            return count;
        }

        public void Display2()
        {
            for (int i = 0; i < qArray.Length; i++)
            {
                if (i == 0)
                {
                    //Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(qArray[0]);
                    //Console.ForegroundColor = ConsoleColor.White;
                }
                else if (i == qArray.Length - 1)
                {
                    Console.Write(" - ");
                    //Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(qArray[i]);
                    //Console.ForegroundColor = ConsoleColor.White;
                }
                else
                    Console.Write(" - " + qArray[i]);
            }
            Console.Write(" - ");
            //Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(qArray[0]);
            //Console.ForegroundColor = ConsoleColor.White;
        }
        public void Display()
        {
            for (int i = 0; i < qArray.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write(qArray[0]);
                }
                else
                    Console.Write(" - " + qArray[i]);
            }
            Console.Write(" - ");
            //Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[" + qArray[0] + "] - ");
            //Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
