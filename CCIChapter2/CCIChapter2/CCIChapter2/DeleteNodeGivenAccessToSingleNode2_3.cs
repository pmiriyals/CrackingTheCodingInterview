using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter2
{
    class DeleteNodeGivenAccessToSingleNode2_3
    {
        static void deleteNode(Node n)
        {
            if (n == null || n.next == null)
                return;

            if (n.next != null)
            {
                n.data = n.next.data;
                n.next = n.next.next;
            }
            
        }
        
        public static void driver()
        {
            LinkedList list = new LinkedList();
            Node head = list.buildList(10);
            Console.WriteLine("Before deleting: ");
            LinkedList.printList(head);
            deleteNode(head.next.next.next.next);
            Console.WriteLine("\nAfter deleting: ");
            LinkedList.printList(head);
        }
    }
}
