using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter3
{
    class SetOfStacks3_3
    {
        private List<Stack<int>> stk = new List<Stack<int>>();
        private int max = 3;
        private int cur = -1;

        public void push(int val)
        {
            if (stk.Count == 0 || stk[cur].Count >= max)
            {
                stk.Add(new Stack<int>());
                cur++;
            }
            if (stk[cur].Count < max)
                stk[cur].Push(val);
            Console.WriteLine("Pushed into stack = {0}", cur);
        }

        public int pop()
        {
            if (stk.Count == 0 || stk[0].Count == 0)
                throw new Exception("Invalid");

            if (stk[cur].Count == 0)
                cur--;
            Console.WriteLine("Popped from stack = {0}", cur);
            return stk[cur].Pop();
        }

        public bool IsEmpty()
        {
            return stk[0].Count == 0;
        }

        public static void driver()
        {
            SetOfStacks3_3 stk = new SetOfStacks3_3();
            for (int i = 0; i < 15; i++)
            {
                stk.push(i);
            }

            while (!stk.IsEmpty())
                Console.WriteLine("Popped = {0}", stk.pop());
        }
    }
}
