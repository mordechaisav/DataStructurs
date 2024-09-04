using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurs
{
    internal class BinaryTree
    {
        private TreeNode _root;
        public BinaryTree()
        {
            _root = null;
        }
        public void Insert (int value)
        {
           _root = InsertRecursiv(_root, value);
           
            
        }
        private TreeNode InsertRecursiv(TreeNode root, int value)
        {
            if (root == null)
            {
                root = new TreeNode(value);
                return root;
            }

            if (root.Value < value)
            {
                root.Right = InsertRecursiv(_root.Right, value);
            }
            else
            {
                root.Left = InsertRecursiv(_root.Left, value);
            }      
            return root;
        }
        public bool Find(int value)
        {
            return FindRecursiv(_root, value);
        }
        private bool FindRecursiv(TreeNode root, int value)
        {
            if (root == null)
            {
                return false;
            }
            if (root.Value == value)
            {
                return true;
            }
            if (root.Value < value)
            {
                return FindRecursiv(_root.Right, value);
            }
            else
            {
                return FindRecursiv(_root.Left, value);
            }
        }
        public int? GetMin()
        {
            return GetMinRecursiv(_root);
        }
        private int? GetMinRecursiv(TreeNode node)
        {
            if (node == null)
                { return null; }
            if (node.Left == null)
            {
                return node.Value;
            }
            return GetMinRecursiv(_root.Left);

        }
        public int? GetMax()
        {
            return MaxRecursiv(_root);
        }
        private int? MaxRecursiv(TreeNode node)
        {
            if (node == null) { return null; }
            if (node.Right == null)
            {
                return node.Value;
            }
            return MaxRecursiv(_root.Right);
        }

    }
}
