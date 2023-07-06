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
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("");
                        Linked linked = new Linked();
                        linked.List();
                        break;
                }



            }
        }
    }
}
