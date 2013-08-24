using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter2
{
    class CircularList
    {
        static void FindStartOfLoop(Node node)
        {
            Node slow = node;
            Node fast = node;

            while (fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;

                if (slow == fast)
                    break;
            }
            if (fast == null)
            {
                Console.WriteLine("There is no loop");
                return;
            }
            Console.WriteLine("Slow/Fast meeting point: {0}", fast.data);

            slow = node;
            while (slow != fast && fast != null)
            {
                slow = slow.next;
                fast = fast.next;
            }
            
            Console.WriteLine("Start of loop node: {0}", slow.data);
        }
        
        public static void driver()
        {
            LinkedList list = new LinkedList();
            Node head = list.buildList(10);
            Node cur = head;
            while (cur.next != null)
                cur = cur.next;
            cur.next = head.next.next.next;
            Console.WriteLine("Last node: {0}", cur.data);
            Console.WriteLine("Loop Start node: {0}", cur.next.data);
            FindStartOfLoop(head);
        }
    }
}
