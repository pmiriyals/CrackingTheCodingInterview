using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter3
{
    class SortStack3_6
    {
        Stack<int> stk = new Stack<int>();

        public void push(int val)
        {
            stk.Push(val);
        }

        public void Sort()
        {
            Stack<int> buf = new Stack<int>();

            while (stk.Count > 0)
            {
                int val = stk.Pop();

                while (buf.Count > 0 && buf.Peek() < val)
                    stk.Push(buf.Pop());
                buf.Push(val);
            }
            stk = buf;
        }

        public bool IsEmpty()
        {
            return stk.Count == 0;
        }

        public int pop()
        {
            return stk.Pop();
        }

        public static void driver()
        {
            int[] arr = { 3, 6, 1, 8, 2, 9, 4, 5};
            SortStack3_6 stack = new SortStack3_6();

            foreach (int i in arr)
                stack.push(i);
            stack.Sort();

            while (!stack.IsEmpty())
                Console.Write("{0} ", stack.pop());
        }

    }
}
