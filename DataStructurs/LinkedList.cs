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
            if (temp!= null)
            {
                str +=temp.Value.ToString();
                temp = temp.Next;
            }
            while (temp != null)
            {
                str += " -> "+temp.Value.ToString();
              
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
        public void RemoveAllValues(int data)
        {
          
            while (Head != null && Head.Value == data)
            {
                Head = Head.Next;
            }

           
            if (Head == null)
            {
                return;
            }

           
            Node temp = Head.Next;
            Node prev = Head;

            while (temp != null)
            {
                if (temp.Value == data)
                {
                    prev.Next = temp.Next;
                }
                else
                {
                    prev = temp;
                }
                temp = temp.Next;
            }
        }

        // O(n)
        public void RemoveIndex(int index)
        {
            if (index == 0)
            {
                if (Head != null)
                {
                    Head = Head.Next;
                }
                return;
            }

            if (Head == null || index < 0)
            {
                return;
            }

            Node temp = Head;
            Node prev = null;

            for (int i = 0; i < index && temp.Next != null; i++)
            {
                prev = temp;
                temp = temp.Next;
            }

            if (temp != null && prev != null)
            {
                prev.Next = temp.Next;
            }
        }

        public int Find(int data)
        {
            Node temp = Head;
            int index = 0;

            while (temp != null)
            {
                if (temp.Value == data)
                {
                    return index; 
                }
                temp = temp.Next; 
                index++;
            }

            return -1; 
        }
        public int Get(int index)
        {
            if (index < 0)
            {
                return -1;
            }
            Node temp = Head;
            if (temp == null)
            {
                return -1;
            }
            int currentIndex = 0;

            while (temp != null)
            {
                if (currentIndex == index)
                {
                    return temp.Value; 
                }
                temp = temp.Next; 
                currentIndex++; 
            }


            return -1;
        }







    }
}




