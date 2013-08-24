using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter2
{
    class AddLists2_4
    {
        static Node AddLists(Node a, Node b)
        {
            Node dummy = new Node(-1);
            Node sum = dummy;
            int carry = 0;
            while (a != null && b != null)
            {
                int val = a.data + b.data + carry;
                Node cur = new Node(val % 10);
                carry = val / 10;
                sum.next = cur;
                sum = cur;
                a = a.next;
                b = b.next;
            }

            while (a != null)
            {
                int val = a.data + carry;
                Node cur = new Node(val % 10);
                carry = val / 10;
                sum.next = cur;
                sum = cur;
                a = a.next;
            }

            while (b != null)
            {
                int val = b.data + carry;
                Node cur = new Node(val % 10);
                carry = val / 10;
                sum.next = cur;
                sum = cur;
                b = b.next;
            }

            if (carry > 0)
                sum.next = new Node(carry);

            return dummy.next;
        }
        
        public static void driver()
        {
            LinkedList listA = new LinkedList();
            Node a = listA.buildList(10);
            LinkedList listB = new LinkedList();
            Node b = listB.buildList(11);
            Node sumList = AddLists(a, b);
            Console.WriteLine("List a: ");
            LinkedList.printList(a);
            Console.WriteLine("\nList a: ");
            LinkedList.printList(b);
            Console.WriteLine("\nSum: ");
            LinkedList.printList(sumList);
        }
    }
}
