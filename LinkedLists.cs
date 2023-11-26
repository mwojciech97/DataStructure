using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class OneWayList<T>
    {
        private static OneWayListNode<T>? head;
        #region Find Nodes
        public OneWayListNode<T>? First()
        {
            return head;
        }
        public OneWayListNode<T>? Last()
        {
            return head == null ? head : head.next;
        }
        public OneWayListNode<T>? FindFirst(T data)
        {
            OneWayListNode<T>? node = head;
            while(node != null)
            {
                if (node.data.Equals(data)) return node;
                node = node.next;
            }
            return null;
        }
        public OneWayListNode<T>? FindLast(T data)
        {
            OneWayListNode<T>? node = head;
            OneWayListNode<T>? lastNodeWithValue = null;
            while (node != null)
            {
                if (node.data.Equals(data)) lastNodeWithValue = node;
                node = node.next;
            }
            return lastNodeWithValue;
        }
        #endregion
        #region Print all Nodes
        public void Print()
        {
            if (head == null) return;
            OneWayListNode<T>? node = head;
            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }
        #endregion
        #region Add Nodes
        public void AddFirst(T data)
        {
            OneWayListNode<T> node = new OneWayListNode<T>(data);
            node.next = head;
            head = node;
        }
        public void AddLast(T data)
        {
            OneWayListNode<T> node = new OneWayListNode<T>(data);
            OneWayListNode<T>? last_node = head;
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
        public void AddAfter(OneWayListNode<T>? prev_node, T data)
        {
            if(prev_node == null)
            {
                Console.WriteLine("Given node cannot be null!");
                return;
            }

            OneWayListNode<T> newNode = new OneWayListNode<T>(data);
            newNode.next = prev_node.next;
            prev_node.next = newNode;
        }
        #endregion
    }
    public class OneWayListNode<T>
    {
        public T data;
        public OneWayListNode<T>? next = null;
        public OneWayListNode(T newData)
        {
            data = newData;
        }
    }
}

