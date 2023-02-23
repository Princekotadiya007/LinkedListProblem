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
            Node node = new Node(data);  
            if(head == null)
            {
                this.head = node;   //56  30 70
            }
            else
            {
                Node temp = head;    
                while(temp.Next != null)   
                {
                    temp = temp.Next;
                }
                temp.Next = node;  
            }
            Console.WriteLine("{0} Values Are Inserted", node.data);
        }
    }
}
