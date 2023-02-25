using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    public class LinkedListStack
    {
        public Node top;
        //Push the data in stack
        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }
        //display the data of stack
        public void Display()
        {
            Node temp = this.top;
            Console.WriteLine("Stack is");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        // pop method
        public void Pop()
        {
            if(this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("Value poped is"+this.top.data);
        }
    }
}
