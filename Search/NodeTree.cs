using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class NodeTree
    {
        private int data;
        private NodeTree left;
        private NodeTree right;

        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public NodeTree Left
        {
            get { return left; }
            set { left = value; }
        }
        public NodeTree Right
        {
            get { return right; }
            set { right = value; }
        }

        public NodeTree() 
        {
            Data = default;
            Left = Right = null;
        }
        public NodeTree(int data)
        {
            Data = data;
            Left = Right = null;
        }

        public bool Insert(int x)
        {
            if (x == Data)
            {
                return false;
            }
            if (x < Data)
            {
                if (left == null)
                {
                    left = new NodeTree(x);
                }
                return left.Insert(x);
            }
            else
            {
                if (right == null)
                {
                    right = new NodeTree(x);
                }
                return right.Insert(x);
            }
            return true;
        }
        public void NLR()
        {
            Console.Write(Data + " ");
            if (left != null)
            {
                left.NLR();
            }
            if (right != null)
            {
                right.NLR();
            }
        }
        public void LNR() 
        {
            if (left != null)
            {
                left.NLR();
            }
            Console.Write(Data + " ");
            if (right != null)
            {
                right.NLR();
            }
        }
        public void LRN()
        {
            if (left != null)
            {
                left.NLR();
            }
            if (right != null)
            {
                right.NLR();
            }
            Console.Write(Data + " ");
        }

        public NodeTree SearchNode(int x)
        {
            if (Data == x)
            {
                return this;
            }
            if (x < Data)
            {
                if (left == null)
                {
                    return null;
                }
                return left.SearchNode(x);
            }
            else
            {
                if (right == null)
                {
                    return null;
                }
                return right.SearchNode(x);
            }
        }
        public NodeTree RightMost()
        {
            if (Right == null)
            {
                return this;
            }
            return Right.RightMost();
        }
    }
}
