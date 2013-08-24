using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter3
{
    class QueueUsingStacks3_5
    {
        Stack<int> enQ = new Stack<int>();
        Stack<int> deQ = new Stack<int>();

        public void Enqueue(int val)
        {
            enQ.Push(val);
        }

        public int Dequeue()
        {
            if (deQ.Count == 0)
            {
                while (enQ.Count > 0)
                    deQ.Push(enQ.Pop());
            }

            if (deQ.Count > 0)
                return deQ.Pop();
            else
                return -1;
        }

        public bool IsEmpty()
        {
            return deQ.Count == 0 && enQ.Count == 0;
        }

        public static void driver()
        { 
            QueueUsingStacks3_5 queue = new QueueUsingStacks3_5();
            for (int i = 0; i < 10; i++)
                queue.Enqueue(i);

            while (!queue.IsEmpty())
                Console.Write("{0} ", queue.Dequeue());
        }
    }
}
