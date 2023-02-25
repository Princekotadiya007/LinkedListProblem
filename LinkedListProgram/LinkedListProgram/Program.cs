using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Link list program");
                Console.WriteLine("\n1.Create linkedList, \n2.AddFirstLinkedList, \n3.First element deleted, \n4.Last element deleted,\n5.Search LinkedList");
                Console.WriteLine("Choose the Option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Creating a linked list to add data");
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Display();
                        break;
                    case 2:
                        Console.WriteLine("Adding Data in Linked List in first position");
                        linkedList.ReversOrder(70);
                        linkedList.ReversOrder(30);
                        linkedList.ReversOrder(56);
                        linkedList.Display();
                        break;
                    case 3:
                        Console.WriteLine("The first element deleted");
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveFirstNode();
                        linkedList.Display();
                        break;
                    case 4:
                        Console.WriteLine("The last element deleted");
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveLastNode();
                        linkedList.Display();
                        break;
                    case 5:
                        Console.WriteLine("Search Linked List to find node ");
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Search(30);
                        linkedList.Display();
                        break;
                    case 6:
                        flag = false;
                        break;
                }
            }
        }
    }
}
