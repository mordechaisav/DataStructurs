using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataStructurs
{

    public class Node
    {
        public int Value;
        public Node Next;
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
    public class LinkedList
    {
        private Node Head { get; set; }
        public LinkedList() { }
        // O(1)
        public LinkedList(int data)
        {
            if (Head == null)
                Head = new Node(data);
        }
        // O(n)
        public void Add(int data)
        {
            if (Head == null) { Head = new Node(data); }
            else
            {
                Node temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new Node(data);
            }
        }
        // O(n)
        public string Display()
        {
            Node temp = Head;
            string str = "";
            while (temp != null)
            {
                str += temp.Value.ToString();
                temp = temp.Next;
            }
            return str;
        }
        // O(n)
        public int Length()
        {
            int len = 0;
            Node temp = Head;
            while (temp != null)
            {
                len++;
                temp = temp.Next;
            }
            return len;
        }
        // O(n)
        public void RemoveValue(int data)
        {
            if (Head == null)
            {
                return;
            }
            if (Head.Value == data)
            {
                Head = Head.Next;
                return;
            }
            Node temp = Head;

            while (temp.Next != null)
            {
                if (temp.Next.Value == data)
                {
                    temp.Next = temp.Next.Next;
                    return;
                }
                temp = temp.Next;
            }
        }
        // O(n)
        public void RemoveAllValue(int data)
        {
            if (Head == null)
            {
                return;
            }
            if (Head.Value == data)
            {
                Head = Head.Next;
                return;
            }
            Node temp = Head;

            while (temp.Next != null)
            {
                if (temp.Next.Value == data)
                {
                    temp.Next = temp.Next.Next;
                }
                else
                {

                    temp = temp.Next;
                }
            }

        }
        // O(n)
        public void RemoveIndex(int index)
        {
            if (index == 0 )
            {
                Head = Head.Next;
                return;
            }
            if (Head == null)
            {
                return;
            }
            Node temp = Head;
            while (temp.Next != null && index>0)
            {
                temp= temp.Next;
                index--;    
            }
            if(index == 0)
            {
                temp.Next = temp.Next.Next;
            }
            

        }


    }
}




