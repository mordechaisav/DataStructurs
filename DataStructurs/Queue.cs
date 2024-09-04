using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurs
{
    public class Queue
    {
        public Node Head {  get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }

        public Queue() { }
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (Count == 0)
            {
                Tail = newNode;
                Head = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            Count++;
        }
        public int Dequeue()
        {
            if (Count == 0)
            {
                return -1;
            }
            int value = Head.Value;
            Head = Head.Next;
            Count--;
            return value;
        }
        public int Peek()
        {

        return Head.Value; 
        }
        public int GetCount()
        {
            return Count;
        }
    
    }
}
