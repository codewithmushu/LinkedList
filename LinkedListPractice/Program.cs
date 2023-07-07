using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Linked_List_Node linkedListNode = new Linked_List_Node();

            while (true)
            {
                Console.WriteLine("Please select the options below");
                Console.WriteLine("1 -Linked list.");
                Console.WriteLine("2- Stack ");
                Console.WriteLine("3- Queue");
                Console.WriteLine("4- Linked list node");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Welcome to Linked List");
                        Linked linked = new Linked();
                        linked.List();
                        break;
                    case 2:
                        Console.WriteLine("Welcome to stack");
                        Stack_Demo stack_Demo = new Stack_Demo();
                        stack_Demo.Element();
                        break;
                    case 4:
                        Console.WriteLine("Welcome to Linked List Node");
                        Linked_List_Node linked_List_Node = new Linked_List_Node();
                        linked_List_Node.Add(21);
                        linked_List_Node.Display();
                        linked_List_Node.Add(22);
                        linked_List_Node.Display();
                        linked_List_Node.Add(23);
                        linked_List_Node.Display();
                        break; 
                    case 5:
                        Console.WriteLine();

                        break; 
                }
            }
        }
    }
}
