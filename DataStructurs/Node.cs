using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurs
{
    public class Node
    {
        public int Value;
        public Node Next;
        public Node Prev { get; set; }
        public int GetValue()
        {
            return Value;
        }
        public void SetValue(int value)
        {
            Value = value;
        }
        public Node GetNext()
        {
            return this.Next;
        }
        public void SetNext(Node node)
        {
            Next = node;
        }

        public Node(int data)
        {
            Value = data;
        }


    }
    public class TreeNode
    {
        public TreeNode(int value)
        {
            Value = value;
            Right = null;
            Left = null;
        }

        public int Value { get; set; }
        public TreeNode Right { get; set; }
        public TreeNode Left { get; set; }
    }
}
