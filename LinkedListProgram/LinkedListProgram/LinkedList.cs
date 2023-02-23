using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    public class LinkedList
    {
        public Node head;
        //creating add method to add the data in linked list sequentially
        public void Add(int data) //56  30  70
        {
            Node node = new Node(data); //56 
            if(head == null)
            {
                this.head = node;   //56  30
            }
            else
            {
                Node temp = head;      // 56
                while(temp.Next != null) // 56   
                {
                    temp = temp.Next;
                }
                temp.Next = node;   //30
            }
            Console.WriteLine("{0} Values Are Inserted", node.data);
        }
    }
}
