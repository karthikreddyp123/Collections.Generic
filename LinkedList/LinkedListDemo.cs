using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedListDemo
    {
        public static void Main()
        {
            // Creating a LinkedList of Strings 
            LinkedList<String> linkedList = new LinkedList<String>();

            // Adding nodes in LinkedList 
            linkedList.AddLast("A");
            linkedList.AddLast("B");
            linkedList.AddLast("C");
            linkedList.AddLast("D");
            linkedList.AddLast("E");

            // To check if a value is in LinkedList 
            Console.WriteLine(linkedList.Contains("B"));
            // To get the first node of the LinkedList
            if (linkedList.Count > 0)
                Console.WriteLine("First Element:"+linkedList.First.Value);
            else
                Console.WriteLine("LinkedList is empty");
            // To get the last node of the LinkedList 
            if (linkedList.Count > 0)
                Console.WriteLine("Last Element:" + linkedList.Last.Value);
            else
                Console.WriteLine("LinkedList is empty");
            Console.WriteLine("Total nodes in linkedList are : " + linkedList.Count);

            // Displaying the nodes in LinkedList 
            foreach (string i in linkedList)
            {
                Console.WriteLine(i);
            }
            // Removing the first node from the LinkedList 
            linkedList.Remove(linkedList.First);

            // To get the count of nodes in LinkedList 
            // after removing all the nodes 
            Console.WriteLine("Total nodes in linkedList are : " + linkedList.Count);

            // Displaying the nodes in LinkedList 
            foreach (string i in linkedList)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
