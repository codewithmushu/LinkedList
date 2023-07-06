using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    public class Linked
    {
        //Linked list is a linear data structure which stores the element in a non-contagious location.
        //The node had element are linked with each other using pointers.
        //Linked list class allows insertion and deletion of element from list very fastly.
        //Node - node will be your exact value
        //next - Referance of the next node.

        public void List()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(0);
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            foreach (int val in list)
            {
                Console.WriteLine("Element in the list is :" + val);
                //Console.WriteLine("No of elements in list are :"+ list.Count);
                //Console.WriteLine("Find the element " + list.Contains(5));
                //Console.WriteLine("Elements in the linked list " + val);

            }
            Console.WriteLine("Removed a element from list " + list.Remove(4));
            foreach (int val in list)
            {
                Console.WriteLine("Elements in the list are -" + val);
            }
            Console.WriteLine("Removed a element from list");
            list.Remove(list.First);
            foreach (int val in list)
            {
                Console.WriteLine("Elements in list are " + val);
            }
            Console.WriteLine("Count is " + list.Count);
            Console.WriteLine("Removed a element from list");
            list.Remove(list.Last);
            foreach (int val in list)
            {
                Console.WriteLine("Elements in list are " + val);
            }
            list.Clear();
            foreach (int val in list)
            {
                Console.WriteLine("Detects elements from list " + val);
            }
            Console.WriteLine("Count is " + list.Count);
            if (list.Contains(3) == true)
            {
                Console.WriteLine("The element was present");
            }
            else
            {
                Console.WriteLine("Element not found");
            }

        }

    }
}
