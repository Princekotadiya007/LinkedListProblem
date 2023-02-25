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
        public Node tailNode;
        //Node node;

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
        public void AddFirst(int data)
        {
            Node node = new Node(data);
            if (head == null)
                tailNode = head = node;
            else
            {
                node.next = head;
                head = node;
            }
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
            if(this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = this.head;
                head = node;
                head.next = temp;
            }
            Console.WriteLine("{0} inserted into linked list ", node.data);
        }
        public void RemoveFirstNode()
        {
            if(head == null)
            {
                Console.WriteLine("Linked list is Empty");
            }
            else
            {
                this.head = this.head.next;
                Console.WriteLine("The first element is deleted");
            }
        }
        public void RemoveLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("linked list is empty"); 
            }
            if (head.next == null)
            {
                head = null;
            }
            else
            {
                Node lastNode = this.head;
                while (lastNode.next.next != null)
                {
                    lastNode = lastNode.next;
                }
                lastNode.next = null;
                Console.WriteLine("the last element deleted");
            }
        }
        public void Search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("Given value: " + value + " is present in Linked list");
                    return;
                }
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("Given value: " + value + " is not present in Linked list");
            }
        }
        public void Append(int data)
        {
            Add(data);
        }
        public void Size()
        {
            Node temp = head;
            int count = 0;
            if(temp == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            while(temp != null)
            {
                Console.WriteLine(temp.data+"");
                temp = temp.next;
                count++;
            }
            Console.WriteLine("Count size linkedlist:"+count);
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
