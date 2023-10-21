using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Search;

class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[] { 10, 5, 7, 3, 9, 2, 15, 2 };


        #region Queue "Static Array"
        //MyQueue<int> queue = new MyQueue<int>(a.Length);
        //for (int i = 0; i < a.Length; i++)
        //{
        //    queue.EnQueue(a[i]);
        //}
        //int top;
        //int last;
        //int deq;
        //Random random = new Random();

        #region Test
        //queue.Top(out top);
        //queue.Display();

        //queue.DeQueue(out deq);
        //Console.WriteLine("Dequeue:  " + deq);
        //queue.Top(out top);
        //queue.Display();

        //queue.DeQueue(out deq);
        //Console.WriteLine("Dequeue:  " + deq);
        //queue.Top(out top);
        //queue.Last(out last);
        //queue.Display();

        //queue.EnQueue(random.Next(0, 10));
        //queue.Top(out top);
        //queue.Last(out last);
        //queue.Display();

        //queue.EnQueue(random.Next(0, 10));
        //queue.Top(out top);
        //queue.Last(out last);
        //queue.Display();

        //queue.EnQueue(random.Next(0, 10));
        //queue.Top(out top);
        //queue.Last(out last);
        //queue.Display();
        #endregion


        #endregion

        #region postfix
        //Console.Write("Nhap phep tinh:   ");
        //string s = Console.ReadLine();
        //List<string> t = new List<string>();
        //Stack<string> stack = new Stack<string>();

        //t = Postfix(stack, s, t);
        //foreach (var item in t)
        //{
        //    Console.Write(item + " ");
        //}
        //Console.WriteLine();
        ////Console.ForegroundColor = ConsoleColor.Red;
        ////Console.WriteLine("Ket qua:  " + s);
        ////Console.ForegroundColor = ConsoleColor.White;

        //s = Calculate(stack, t);

        //Console.ForegroundColor = ConsoleColor.Red;
        //Console.WriteLine("Ket qua:  " + s);
        //Console.ForegroundColor = ConsoleColor.White;

        ///
        ///LỖI => FIX: dùng "mảng" thay "t"
        ///
        #endregion

        #region Stack "Static Array"
        //MyStack stack = new MyStack();

        //bool checkPush = stack.Push(2);
        //if (checkPush)
        //{
        //    Console.WriteLine("Pushed!");
        //}
        //else
        //{
        //    Console.WriteLine("Not working!");
        //}

        //Console.WriteLine(stack.Peek());

        //int a;
        //bool checkPop = stack.Pop(out a);
        //if (checkPop)
        //{
        //    Console.WriteLine("Popped!");
        //}
        //else
        //{
        //    Console.WriteLine("Not working!");
        //}
        #endregion

        #region LinkedList
        MyLinkedList<int> obj = new MyLinkedList<int>(a);
        obj.Display();
        #endregion
    }

    static int Transform(string s)
    {
        if (s == "/" || s == "*")
        {
            return 1;
        }
        else if (s == "+" || s == "-")
        {
            return 2;
        }
        else if (s == "(" || s == ")")
        {
            return 3;
        }

        return 0;
    }
    static List<string> Postfix(MyStack<string> stack, string s, List<string> t)
    {
        for (int i = 0; i < s.Length; i++)
        {
            char token = s[i];
            if (char.IsDigit(token))
            {
                t.Add(token.ToString());
            }
            else
            {
                if (stack.IsEmpty())
                {
                    stack.Push(token.ToString());
                }
                else
                {
                    string top = stack.Peek();
                    int topList = Transform(top);
                    int tokenChar = Transform(token.ToString());
                    if (token == '(')
                    {
                        stack.Push(token.ToString());
                    }
                    else if (token == ')')
                    {
                        while (stack.Peek() != "(")
                        {
                            t.Add(stack.Pop());
                        }
                        stack.Pop();
                    }
                    else if (topList == tokenChar)
                    {   
                        t.Add(stack.Pop());
                        stack.Push(token.ToString());
                    }
                    else if(topList < tokenChar)
                    {
                        while (!stack.IsEmpty())
                        {
                            t.Add(stack.Pop());
                        }
                        stack.Push(token.ToString());
                    }
                    else
                    {
                        stack.Push(token.ToString());
                    }
                }
            }
            //stack.Display();
        }
        while (!stack.IsEmpty())
        {
            t.Add(stack.Pop());
        }

        return t;
    }
    static string Calculate(MyStack<string> stack, List<string> t)
    {
        for (int i = 0; i < t.Count; i++)
        {
            string token = t[i];
            if (char.IsNumber(token,0))
            {
                stack.Push(token.ToString());
            }
            else
            {
                int top = int.Parse(stack.Pop());
                int belowTop = int.Parse(stack.Pop());
                switch (token)
                {
                    case "+":
                        {
                            stack.Push((belowTop + top).ToString());
                            break;
                        }
                    case "-":
                        {
                            stack.Push((belowTop - top).ToString());
                            break;
                        }
                    case "*":
                        {
                            stack.Push((belowTop * top).ToString());
                            break;
                        }
                    case "/":
                        {
                            stack.Push((belowTop / top).ToString());
                            break;
                        }
                    default:
                        break;
                }
            }

            //stack.Display();
        }

        return stack.Pop();
    }
}