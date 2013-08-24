using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter2
{
    class RemoveDuplicates2_1
    {
        static void RemoveDuplicates(Node node)
        {
            if (node == null)
                return;

            HashSet<int> hs = new HashSet<int>();
            hs.Add(node.data);
            while (node.next != null)
            {
                if (hs.Contains(node.next.data))
                {
                    node.next = node.next.next;
                }
                else
                {
                    node = node.next;
                    hs.Add(node.data);
                }
            }
        }
        
        public static void driver()
        {
            int[] arr = { 1, 5, 2, 7, 3, 1, 8, 2, 8 };
            LinkedList list = new LinkedList();
            Node head = list.buildList(arr);
            RemoveDuplicates(head);
            LinkedList.printList(head);
        }
    }
}
