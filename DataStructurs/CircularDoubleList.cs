using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurs
{
    public class CircularDoubleList
    {
        public Node Head;
        public int count;
        public CircularDoubleList()
        {
            Head = null;
            this.count = 0;
        }
        public void AddLast(int value)
        {
            Node node = new Node(value);
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Node tail = Head.Prev;
                 
            }
        }
    }
}
