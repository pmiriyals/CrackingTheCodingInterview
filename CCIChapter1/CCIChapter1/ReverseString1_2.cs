using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter1
{
    class ReverseString1_2
    {   
        static void RevRecur(char[] s, int start, int end)
        {
            if (start >= end)
            {
                Console.WriteLine(s);
                return;
            }

            char c = s[start];
            s[start] = s[end];
            s[end] = c;

            RevRecur(s, start + 1, end - 1);
        }

        static void RevIter(string s)
        {
            Console.WriteLine("Using iterative approach: ");
            for (int i = s.Length - 1; i >= 0; i--)
                Console.Write("{0}", s[i]);
        }

        public static void driver()
        {
            string s = "Reverse";
            RevRecur(s.ToCharArray(), 0, s.Length - 1);
            RevIter(s);
        }
    }
}
