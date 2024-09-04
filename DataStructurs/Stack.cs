using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurs
{
    public class Stack
    {
        public Node Top {  get; set; }
        public int Count { get; set; }

    public void Push (int data)
    {
        Node newNode = new Node(data);
            if (Count == 0)
            {
                Top = newNode;
            }
            else
            {
                newNode.Next = Top;
                Top = newNode;
            }
                Count++;
    }
        public int Pop ()
        {
            if (Count == 0)
            {
                return -1;
            }
            int value = Top.Value;
            Top = Top.Next;
            
            Count--;
            return value;
        }
        public int Peek()
        {
            if(Count == 0)
            {
                return -1;
            }
            return Top.Value;
        }
        public int GetCount()
        {
            return this.Count;
        }
    }
}
