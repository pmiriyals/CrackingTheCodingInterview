using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter2
{
    class NthFromLast2_2
    {
        public static void GetNthFromEnd(Node node, int n)
        {
            if (n <= 0 || node == null)
                return;

            Node fast = node;
            Node slow = node;

            for (int i = 0; i < n; i++)
            {
                if (fast != null)
                    fast = fast.next;
                else
                {
                    Console.WriteLine("Invalid n");
                    return;
                }
            }

            while (fast != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            Console.WriteLine("Nth from last = {0}", slow.data);
        }

        public static void driver()
        {
            LinkedList list = new LinkedList();
            Node head = list.buildList(10);
            LinkedList.printList(head);
            Console.WriteLine();
            GetNthFromEnd(head, 11);
        }
    }
}
