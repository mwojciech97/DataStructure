using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class OneWayList
    {
        private static Node head;
        private static Node currentNode;
        private class Node
        {
            public int data;
            public Node next;
        }
        public void Print()
        {
            Node node = head;
            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }
        public void Push(int newData)
        {
            Node node = new Node();
            node.data = newData;
            node.next = null;
            if (head == null)
            {
                head = node;
                currentNode = node;
            }
            if (currentNode != null)
            {
                currentNode.next = node;
                currentNode = node;
            }   
        }
    }
    
 
}

