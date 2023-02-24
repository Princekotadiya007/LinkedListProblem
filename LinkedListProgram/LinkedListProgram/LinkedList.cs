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
                while(temp.next != null)   
                {
                    temp = temp.next;
                }
                temp.next = node;  
            }
            Console.WriteLine("{0} Values Are Inserted", node.data);
        }
        //public void AddFirst(int data) 
        //{
        //    Node node = new Node(data);
        //    node.next = this.head;     
        //    this.head = node;  
        //    Console.WriteLine("{0} inserted into linked list ", node.data); 
        //}
        public void ReversOrder(int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                head = node;
                head.next = temp;
            }
            Console.WriteLine("{0} inserted into linked list ", node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Liked List Is Empty");
            }
            Console.WriteLine("Linked list is :");
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }
    }
}
