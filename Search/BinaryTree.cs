using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class BinaryTree<T>
    {
        NodeTree root;
        public BinaryTree()
        {
            root = null;
        }

        public bool Insert(int x)
        {
            if (root == null)
            {
                root = new NodeTree(x);
                return true;
            }
            return root.Insert(x);
        }
        public void PreOrder()
        {
            if (root == null)
            {
                Console.WriteLine("Empty Tree..!");
            }
            root.NLR();
        }
        public void InOrder()
        {
            if (root == null)
            {
                Console.WriteLine("Empty Tree..!");
            }
            root.LNR();
        }
        public void PosOrder()
        {
            if (root == null)
            {
                Console.WriteLine("Empty Tree..!");
            }
            root.LRN();
        }

        public NodeTree SearchNode(int x)
        {
            if (root == null)
            {
                return null;
            }
            return root.SearchNode(x);
        }
        public NodeTree NodeMax()
        {
            if (root == null)
            {
                return null;
            }
            return root.RightMost();
        }
    }
}
