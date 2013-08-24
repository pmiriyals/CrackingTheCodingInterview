using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter3
{
    class node
    {
        public int data { get; set; }
        public int prev { get; set; }

        public node(int data, int prev)
        {
            this.data = data;
            this.prev = prev;
        }
    }

    class SingleArrThreeStks3_1
	{
        private const int max = 300;
        private const int n = 3;
        private node[] stk = new node[max * n];
        private int[] stkptr = new int[n];
        private List<int> lstFreeNdx;
        private int top;

        public SingleArrThreeStks3_1()
        {
            initialize();
        }

        private void initialize()
        {
            for (int i = 0; i < stkptr.Length; i++)
                stkptr[i] = -1;

            top = 0;
            lstFreeNdx = new List<int>();
        }

        public void push(int data, int stkNum)
        {
            if (stkNum >= n)
                return;
            int ndx;
            if (lstFreeNdx.Count > 0)
            {
                ndx = lstFreeNdx[0];
                lstFreeNdx.RemoveAt(0);                
            }
            else
            {
                if (top >= (n * max))
                    return;
                ndx = top++;
            }
            stk[ndx] = new node(data, stkptr[stkNum]);
            stkptr[stkNum] = ndx;
        }

        public int pop(int stkNum)
        {
            if (stkNum >= n || stkptr[stkNum] < 0)
                return -1;

            int ndx = stkptr[stkNum];
            node cur = stk[ndx];
            stkptr[stkNum] = cur.prev;
            lstFreeNdx.Add(ndx);
            return cur.data;
        }

        public int peek(int stkNum)
        {
            if (stkNum >= n || stkptr[stkNum] < 0)
                return -1;

            return stk[stkptr[stkNum]].data;
        }

        public bool IsEmpty()
        {
            return lstFreeNdx.Count == top;
        }

        public static void driver()
        {
            SingleArrThreeStks3_1 stack = new SingleArrThreeStks3_1();

            stack.push(1, 0);
            stack.push(2, 0);
            stack.push(3, 1);
            stack.push(4, 1);
            stack.push(5, 2);
            stack.push(6, 2);
            stack.push(7, 1);
            stack.push(8, 0);
            stack.push(9, 2);

            int ndx = 0;
            while (!stack.IsEmpty())
            {                
                Console.WriteLine("Pop from Stack[{2}] = {0}\t Peek from {2} = {1}", stack.pop(ndx%3), stack.peek(ndx%3), ndx%3);
                ndx++;
            }
        }

	}
}
