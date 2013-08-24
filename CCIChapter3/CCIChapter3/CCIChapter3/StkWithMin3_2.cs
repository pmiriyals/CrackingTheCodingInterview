using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter3
{
    class StkWithMin3_2 : Stack<int>
    {
        private Stack<int> minStk = new Stack<int>();

        public void push(int val)
        {
            base.Push(val);
            if (minStk.Count == 0 || minStk.Peek() >= val)
                minStk.Push(val);
        }

        public int Min()
        {
            if (minStk.Count > 0)
                return minStk.Peek();
            else
                return -1;
        }

        public int peek()
        {
            return base.Peek();
        }

        public int pop()
        {
            int val = base.Peek();
            if (val == minStk.Peek())
                minStk.Pop();
            base.Pop();
            return val;
        }

        public static void driver()
        {
            int[] arr = { 6, 10, 5, 2, 7, 2, 6, 9 };
            StkWithMin3_2 stk = new StkWithMin3_2();
            foreach (int i in arr)
                stk.push(i);

            while (stk.Count > 0)
                Console.WriteLine("Stack min = {0} \t Stack pop = {1}", stk.Min(), stk.pop());
        }
    }
}
