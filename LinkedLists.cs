using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class OneWayList
    {
        private static OneWayListNode? head;
        public OneWayListNode? First()
        {
            return head;
        }
        public OneWayListNode? Last()
        {
            return head == null ? head : head.next;
        }
        public void Print()
        {
            if (head == null) return;
            OneWayListNode? node = head;
            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }
        public void AddFirst(int data)
        {
            OneWayListNode node = new OneWayListNode();
            node.data = data;
            node.next = head;
            head = node;
        }
        public void AddLast(int data)
        {
            OneWayListNode node = new OneWayListNode(data);
            OneWayListNode? last_node = head;
            if(last_node == null)
            {
                head = node;
                return;
            }
            while(last_node.next != null)
            {
                last_node = last_node.next;
            }
            last_node.next = node;
        }
        public void AddAfter(OneWayListNode? prev_node, int data)
        {
            if(prev_node == null)
            {
                Console.WriteLine("Given node cannot be null!");
                return;
            }

            OneWayListNode newNode = new OneWayListNode(data);
            newNode.next = prev_node.next;
            prev_node.next = newNode;
        }
    }
    public class OneWayListNode
    {
        public int data;
        public OneWayListNode? next = null;
        public OneWayListNode() { }
        public OneWayListNode(int newData)
        {
            data = newData;
        }
    }

}

