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
                Console.WriteLine("\n1.Create linkedList");
                Console.WriteLine("Choose the Option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Display();
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}
