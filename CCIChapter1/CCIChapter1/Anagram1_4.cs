using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter1
{
    class Anagram1_4
    {
        //O(n), with extra space
        static bool IsAnagramUsingCountArr(string a, string b)
        {
            if (a == null && b == null)
                return true;
            
            if (a == null || b == null || a.Length != b.Length)
                return false;
            
            int[] cnt = new int[256];

            for (int i = 0; i < a.Length; i++)
            {
                cnt[a[i]]++;
                cnt[b[i]]--;
            }

            for (int i = 0; i < cnt.Length; i++)
                if (cnt[i] != 0)
                    return false;

            return true;
        }

        //O(n log n)
        static bool IsAnagramUsingSorting(string a, string b)
        {
            return false;
        }

        public static void driver()
        {
            string a = "anaagraam";
            string b = "maaanarga";

            Console.WriteLine("IsAnagram = {0}", IsAnagramUsingCountArr(a, b));
        }
    }
}
