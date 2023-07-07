using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    public class Stack_Demo
    {
        public void Element()
        {
            //Last in First out
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2.65);
            stack.Push("Muskan");
            stack.Push("b");
            stack.Push("Shaikh");
            foreach (var item in stack)
            {
                Console.WriteLine("Stack item :"+item);
            }
            Console.WriteLine("********************************");
            Console.WriteLine("Items in Stack Are :" + stack.Count);
            Console.WriteLine("********************************");
            Console.WriteLine("Element Present is :"+stack.Contains("Muskan"));
            Console.WriteLine("********************************");
            Console.WriteLine("Peek Element is :"+stack.Peek());
            foreach (var item in stack)
            {
                Console.WriteLine("Stack item :"+item);
            }
            Console.WriteLine("********************************");
            Console.WriteLine("pop item :"+ stack.Pop());
            foreach (var item in stack)
            {
                Console.WriteLine("Stack pop item :" + item);
            }


        }
    }
}
