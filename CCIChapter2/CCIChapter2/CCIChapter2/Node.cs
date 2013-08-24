using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter2
{
    public class Node
    {
        public int data { get; set; }
        public Node next;

        public Node(int data) : this(data, null) { }
        public Node(int data, Node next)
        {
            this.data = data;
            this.next = next;
        }
    }

    public class LinkedList
    {
        public Node head = null;

        public Node buildList(int[] arr)
        { 
            Node cur;
            foreach (int i in arr)
            {
                cur = new Node(i);
                cur.next = head;
                head = cur;
            }

            return head;
        }

        public Node buildList(int size)
        {
            Node cur;
            for (int i = size; i >= 1; i--)
            {
                cur = new Node(i);
                cur.next = head;
                head = cur;
            }
            return head;
        }

        public static void printList(Node node)
        {
            Console.Write("List: ");
            while (node != null)
            {
                Console.Write("{0} ", node.data);
                node = node.next;
            }
        }
    }
}
